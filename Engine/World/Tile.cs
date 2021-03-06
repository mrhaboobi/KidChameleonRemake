﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Collision;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Engine
{
    [Flags]
    public enum TileFlags
    {
        Passable = 0,
        Solid = 1,
        Breakable = 2,
        Special = 4,
        Invisible = 8,
        Sloped = 16,
        OutOfBounds = 512
    }


    public class TileDef : ISerializableBaseClass
    {

        #region Defaults

        private static TileDef _blankTile;
        public static TileDef Blank
        {
            get
            {
                if (_blankTile == null)
                {
                    _blankTile = new TileDef(TileFlags.Invisible, 0, 0, RGPoint.Empty, new DirectionFlags());
                   // _blankTile.Usage.SingleGroup = "empty";
                }

                return _blankTile;
            }
        }

        private static TileDef _blankSolidTile;
        public static TileDef BlankSolid
        {
            get
            {
                if (_blankSolidTile == null)
                {
                    _blankSolidTile = new TileDef(TileFlags.Invisible | TileFlags.Solid, -1, 0, RGPoint.Empty, new DirectionFlags());
                 //   _blankSolidTile.Usage.SingleGroup = "empty";
                }

                return _blankSolidTile;
            }
        }

        private static TileDef _oobTile;
        public static TileDef OutOfBounds
        {
            get
            {
                if (_oobTile == null)
                    _oobTile = new TileDef(TileFlags.OutOfBounds, 0, 0, RGPoint.Empty, new DirectionFlags());

                return _oobTile;
            }
        }
      
        #endregion


        #region Editor Only Properties

        [DisplayName("Sides")]
        public EditorDirectionFlags _SidesForEditor
        {
            get
            {
                return Sides.ToEditorFlags();
            }
            set
            {
                this.Sides = new DirectionFlags(value);
            }
        }


        [DisplayName("Automatch Group")]
        public string _AutomatchGroupForEditor
        {
            get
            {
                return this.Usage.AutomatchGroup;
            }
            set
            {
                this.Usage.AutomatchGroup = value;
            }
        }


        [DisplayName("Flags")]
        public TileFlags _FlagsForEditor { get { return this.Flags; } set { this.Flags = value; } }
     
        #endregion

        #region Properties

        private ulong lastFrameTime = 0;
        private int frameIndex = 0;

        [Browsable(false)]
        public int TileID { get; private set; }

        [Browsable(false)]
        public TileFlags Flags { get; private set; }

        [Browsable(false)]
        public bool IsPassable { get { return ((this.Flags & TileFlags.Solid) == 0) && ((this.Flags & TileFlags.Sloped) == 0); } }

        [Browsable(false)]
        public bool IsBlank { get { return (this.Flags & TileFlags.Invisible) > 0; } }

        [Browsable(false)]
        public bool IsSolid { get { return (this.Flags & TileFlags.Solid) > 0; } }

        [Browsable(false)]
        public bool IsOutOfBounds { get { return (this.Flags & TileFlags.OutOfBounds) > 0; } }

        [Browsable(false)]
        public bool IsSloped { get { return (this.Flags & TileFlags.Sloped) > 0; } }

        [Browsable(false)]
        public bool IsSpecial { get { return (this.Flags & TileFlags.Special) > 0; } }


        [Browsable(false)]
        public RGRectangleI[] SourcePositions { get; private set; }

        [Browsable(false)]
        public int FrameDuration { get; private set; }

        [Browsable(false)]
        public TileUsage Usage { get; private set; }

        [Browsable(false)]
        public DirectionFlags Sides { get; private set; }

        #endregion

        public RGRectangleI SourcePosition
        {
            get
            {
                if (SourcePositions.Length == 0)
                    return RGRectangleI.Empty;
                return SourcePositions[frameIndex];
            }
        }

        public RGPoint DestOffset { get; private set; }

        public void UpdateAnimation(GameContext context)
        {
            if (context.CurrentFrameNumber >= lastFrameTime + (ulong)FrameDuration)
            {
                lastFrameTime = context.CurrentFrameNumber;
                frameIndex++;
                if (frameIndex >= SourcePositions.Length)
                    frameIndex = 0;
            }
        }

   
       
        public TileDef() 
        {
            this.Usage = new TileUsage();
        }

        public TileDef(TileFlags flags, int id, int frameDuration, RGPoint destOffset, DirectionFlags sides, TileUsage usage, params RGRectangleI[] sources)
        {
            this.Sides = sides;
            this.SourcePositions = sources;
            this.Flags = flags;
            this.TileID = id;
            this.FrameDuration = frameDuration;

            this.Usage = usage;
        }

        public TileDef(TileFlags flags, int id, int frameDuration, RGPoint destOffset, DirectionFlags sides, params RGRectangleI[] sources)
        {
            this.Sides = sides;
            this.SourcePositions = sources;
            this.Flags = flags;
            this.TileID = id;
            this.FrameDuration = frameDuration;

            this.Usage = new TileUsage(); ;
        }

        #region Saving

        private class TileSaveModel
        {
            public int ID;
            public TileFlags Flags;
            public RGRectangleI[] SourcePositions;
            public int FrameDuration;
            public DirectionFlags Sides;
            public Dictionary<Side, int[]> SideMatches = new Dictionary<Side, int[]>();
            public string[] Groups;
            public String AutomatchGroup;

            public object ExtraData;
        }

        public object GetSaveModel()
        {
            var sideMatches = new Dictionary<Side, int[]>();
            foreach (Side key in Enum.GetValues(typeof(Side)))
                sideMatches.Add(key, this.Usage.GetMatches(key).Select(p=>p.TileID).ToArray());

            return new TileSaveModel
            {
                Flags = this.Flags,
                ID = this.TileID,
                SourcePositions = this.SourcePositions,
                FrameDuration = this.FrameDuration,
                Sides = this.Sides,
                SideMatches = sideMatches,
                Groups = this.Usage.Groups.ToArray(),
                AutomatchGroup = this.Usage.AutomatchGroup,
                ExtraData = GetSaveModelExtra()
            };
        }

        protected virtual object GetSaveModelExtra()
        {
            return null;
        }

        protected virtual void LoadExtra(object data)
        {

        }

        public Type GetSaveModelType()
        {
            return typeof(TileSaveModel);
        }

        public void Load(object saveModel)
        {
            var model = saveModel as TileSaveModel;
            this.TileID = model.ID;
            this.Flags = model.Flags;
            this.SourcePositions = model.SourcePositions;
            this.FrameDuration = model.FrameDuration;
            this.Sides = model.Sides;
            this.Usage.AutomatchGroup = model.AutomatchGroup;

            foreach (var key in model.SideMatches.Keys)
            {
                foreach (var id in model.SideMatches[key])
                {
                    var tempDef = new TileDef();
                    tempDef.SetValues(id, null, null, null);
                    this.Usage.AddMatch(key, tempDef);
                }
            }

            this.Usage.Groups = model.Groups.NeverNull().ToList();
            this.LoadExtra(model.ExtraData);
        }


        Type ISerializableBaseClass.GetTargetType()
        {
            var dummy = Engine.Core.GameBase.Current.TileInstanceCreate();
            return dummy.TileDef.GetType();
        }

    
     

        #endregion

        public int? GetYIntercept(RGRectangleI tileLocation, int x)
        {
            int yIntercept, yLeft, yRight;

            if (Sides.Left)
            {
                yLeft = tileLocation.Top;
                yRight = tileLocation.Bottom;
            }
            else if (Sides.Right)
            {
                yLeft = tileLocation.Bottom;
                yRight = tileLocation.Top;
            }
            else
                return null;

            var cx = x;
            if (cx < tileLocation.Left || cx > tileLocation.Right)
                return null;

            var yDiff = yRight - yLeft;
            var xPct = (float)(cx - tileLocation.Left) / tileLocation.Width;
            yIntercept = (int)(yLeft + (yDiff * xPct));

            return yIntercept;
        }

        public override string ToString()
        {
            return this.TileID + " " + this.Flags.ToString() + " " + this.Usage.ToString();
        }

        public void SetValues(int? id, TileFlags? flags, DirectionFlags sides, RGRectangleI? source)
        {
            if (id.HasValue)
                this.TileID = id.Value;

            if (flags.HasValue)
                this.Flags = flags.Value;

            if (sides != null)
                this.Sides = sides;

            if (source.HasValue)
                this.SourcePositions = new RGRectangleI[] { source.Value };
        }

        public override bool Equals(object obj)
        {
            var other = obj as TileDef;
            if (other == null)
                return false;

            return other.TileID == this.TileID;
        }
    }

    public abstract class TileInstance
    {
        [Browsable(false)]
        public abstract TileDef TileDef { get; set; }

        [Browsable(false)]
        public RGPointI TileLocation { get; set; }

        [JsonIgnore]
        [Browsable(false)]
        public Map Map { get; set; }

        [Browsable(false)]
        public RGRectangleI TileArea
        {
            get
            {
                if (Map == null)
                    return RGRectangleI.Empty;

                return Map.GetTileLocation(TileLocation.X, TileLocation.Y);
            }
        }

        public TileInstance GetAdjacentTile(int xOff, int yOff)
        {
            var nextTile = TileLocation.Offset(xOff, yOff);
            return this.Map.GetTileAtGridCoordinates(nextTile.X, nextTile.Y);
        }

        public TileInstance GetAdjacentTile(RGPointI offset)
        {
            return GetAdjacentTile(offset.X, offset.Y);
        }

        public IEnumerable<TileInstance> GetAdjacentTiles()
        {
            yield return GetAdjacentTile(-1, 0);
            yield return GetAdjacentTile(1, 0);
            yield return GetAdjacentTile(0,-1);
            yield return GetAdjacentTile(0, 1);
        }

        public IEnumerable<TileInstance> GetTilesInLine(Direction d)
        {
            var pt = d.ToPoint();
            return GetTilesInLine(pt.X, pt.Y);
        }

        public IEnumerable<TileInstance> GetTilesInLine(int dx, int dy)
        {
            int x = TileLocation.X;
            int y = TileLocation.Y;

            while (true)
            {
                var tile = Map.GetTileAtGridCoordinates(x, y);
                if (tile.TileDef.IsOutOfBounds)
                    break;
                else
                    yield return tile;

                x += dx;
                y += dy;
            }
        }

        public TileInstance ReplaceWith(TileDef newTile)
        {
            if (newTile == null)
                return this;

            this.Map.SetTile(this.TileLocation.X, this.TileLocation.Y, newTile.TileID);
            return this.Map.GetTileAtGridCoordinates(this.TileLocation.X, this.TileLocation.Y);
        }

        public abstract bool IsSpecial { get; }
        public abstract CollidingTile CreateCollidingTile(TileCollisionView collisionView);

        public override bool Equals(object obj)
        {
            var other = obj as TileInstance;
            if (other == null)
                return false;

            return other.TileLocation.Equals(this.TileLocation) &&
                other.TileDef.Equals(this.TileDef);
        }

        #region AdjacentTiles

        [JsonIgnore]
        [Browsable(false)]
        public TileInstance LeftTile { get { return GetAdjacentTile(-1, 0); } }

        [JsonIgnore]
        [Browsable(false)]
        public TileInstance RightTile { get { return GetAdjacentTile(1, 0); } }

        [JsonIgnore]
        [Browsable(false)]
        public TileInstance AboveTile { get { return GetAdjacentTile(0, -1); } }

        [JsonIgnore]
        [Browsable(false)]
        public TileInstance BelowTile { get { return GetAdjacentTile(0, 1); } }

        #endregion
    }


}
