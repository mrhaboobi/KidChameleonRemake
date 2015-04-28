﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine;
using Engine.Collision;

namespace KidC
{

    class HealthController : SpriteBehavior
    {
        public int HitPoints { get; private set; }
    
        public HealthController(Sprite s, int initialHitpoints)
            : base(s)
        {
            this.HitPoints = initialHitpoints;
        }

        protected override void Update()
        {
            if (this.HitPoints <= 0)
                this.Kill(Engine.ExitCode.Destroyed);
         
        }

        public void Damage(int amount)
        {
            HitPoints = Math.Max(0, HitPoints - amount);
        }
    }

    abstract class HitController : TriggeredController<HitInfo>
    {
        private int mDuration;
        private HealthController mHealthController;

        public HitController(Sprite s, int hitDuration, HealthController healthController) : base(s)
        {
            mDuration = hitDuration;
            mHealthController = healthController;
        }

        protected override Switch OnTriggered(HitInfo hitInfo)
        {
            SoundManager.PlaySound(this.GetHitSound(hitInfo.Event));
            OnHit();
            mHealthController.Damage(hitInfo.Damage);
            return Switch.On;
        }

        protected override Switch OnTriggerUpdate(HitInfo hitInfo)
        {
            if (this.TriggerDuration >= mDuration)
                return Switch.Off;
            else
            {
                WhileHit();
                return Switch.On;
            }
        }

        protected override void OnTriggerStop()
        {
            AfterHit();
        }

        protected abstract void OnHit();
        protected abstract void WhileHit();
        protected abstract void AfterHit();

        protected abstract SoundResource GetHitSound(CollisionEvent evt);
        protected abstract bool ShouldHandleCollision(CollisionEvent evt);
        public abstract int GetAttackDamage(CollisionEvent evt);
        protected override void HandleCollisionEx(CollisionEvent cEvent, CollisionResponse response)
        {
            if (ShouldHandleCollision(cEvent))
                response.AddInteraction(new SpriteCollision(cEvent), this);        
        }
    }

    interface IDamager
    {
        int GetAttackDamage(CollisionEvent collision);
    }

    class HitInfo
    {
        public int Damage;
        public CollisionEvent Event;
    }

    class SpriteCollision : Interaction<HitController, HitController>
    {
        private CollisionEvent mHitEvent; 
        public SpriteCollision(CollisionEvent targetHitEvent)
        {
            mHitEvent = targetHitEvent;
        }

        protected override void DoAction(HitController controller1, HitController controller2)
        {
            int damage1 = controller1.GetAttackDamage(mHitEvent.AdjustTo(controller1.Sprite));
            if (damage1 > 0)
                controller2.Trigger(new HitInfo { Damage = damage1, Event = mHitEvent.AdjustTo(controller1.Sprite) });

            int damage2 = controller2.GetAttackDamage(mHitEvent.AdjustTo(controller2.Sprite));
            if (damage2 > 0)
                controller1.Trigger(new HitInfo { Damage = damage2, Event = mHitEvent.AdjustTo(controller2.Sprite) });
        }
    }


    static class CollisionUtil
    {
        public static bool IsStomp(this CollisionEvent evt)
        {
            if (evt.ThisCollisionTimeSpeed.Y < 0)
                return false;

            var prevArea = evt.ThisObjectPreviousPosition;
            return prevArea.Bottom <= evt.OtherArea.Top+2;
        }
    }
}
