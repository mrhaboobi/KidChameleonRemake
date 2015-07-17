﻿namespace Editor.Forms
{
    partial class TilesetEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkFilterExclusive = new System.Windows.Forms.CheckBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnCopyFromSelected = new System.Windows.Forms.Button();
            this.chkProperties = new System.Windows.Forms.CheckedListBox();
            this.btnCopyProperties = new System.Windows.Forms.Button();
            this.tileProperties = new System.Windows.Forms.PropertyGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.SplitContainer();
            this.pnlTileset = new Editor.TilePanelUserControl();
            this.pnlBase = new Editor.TilePanelUserControl();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAutoOrganize = new System.Windows.Forms.Button();
            this.btnAutoDetectSides = new System.Windows.Forms.Button();
            this.txtDblClickGroup = new Editor.TileGroupAdder();
            this.pnlGroupBox = new System.Windows.Forms.Panel();
            this.txtGroupLeftTop = new Editor.TileGroupAdder();
            this.txtGroupBottomRight = new Editor.TileGroupAdder();
            this.pnlTilePreview = new System.Windows.Forms.Panel();
            this.txtGroupBottomLeft = new Editor.TileGroupAdder();
            this.txtGroupLeftBottom = new Editor.TileGroupAdder();
            this.txtGroupTopRight = new Editor.TileGroupAdder();
            this.txtGroupRightTop = new Editor.TileGroupAdder();
            this.txtGroupTopLeft = new Editor.TileGroupAdder();
            this.txtGroupRightBottom = new Editor.TileGroupAdder();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGroupTogether = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.Panel1.SuspendLayout();
            this.pnlMain.Panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlGroupBox.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFilterExclusive
            // 
            this.chkFilterExclusive.AutoSize = true;
            this.chkFilterExclusive.Location = new System.Drawing.Point(12, 32);
            this.chkFilterExclusive.Name = "chkFilterExclusive";
            this.chkFilterExclusive.Size = new System.Drawing.Size(71, 17);
            this.chkFilterExclusive.TabIndex = 5;
            this.chkFilterExclusive.Text = "Exclusive";
            this.chkFilterExclusive.UseVisualStyleBackColor = true;
            this.chkFilterExclusive.CheckedChanged += new System.EventHandler(this.chkFilterExclusive_CheckedChanged);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(12, 6);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(181, 20);
            this.txtGroup.TabIndex = 4;
            this.txtGroup.TextChanged += new System.EventHandler(this.txtGroup_TextChanged);
            // 
            // btnCopyFromSelected
            // 
            this.btnCopyFromSelected.Location = new System.Drawing.Point(249, 13);
            this.btnCopyFromSelected.Name = "btnCopyFromSelected";
            this.btnCopyFromSelected.Size = new System.Drawing.Size(122, 31);
            this.btnCopyFromSelected.TabIndex = 3;
            this.btnCopyFromSelected.Text = "Copy From Selected";
            this.btnCopyFromSelected.UseVisualStyleBackColor = true;
            this.btnCopyFromSelected.Click += new System.EventHandler(this.btnCopyFromSelected_Click);
            // 
            // chkProperties
            // 
            this.chkProperties.FormattingEnabled = true;
            this.chkProperties.Location = new System.Drawing.Point(12, 13);
            this.chkProperties.Name = "chkProperties";
            this.chkProperties.Size = new System.Drawing.Size(231, 79);
            this.chkProperties.TabIndex = 2;
            // 
            // btnCopyProperties
            // 
            this.btnCopyProperties.Location = new System.Drawing.Point(249, 61);
            this.btnCopyProperties.Name = "btnCopyProperties";
            this.btnCopyProperties.Size = new System.Drawing.Size(114, 31);
            this.btnCopyProperties.TabIndex = 1;
            this.btnCopyProperties.Text = "Copy From Base";
            this.btnCopyProperties.UseVisualStyleBackColor = true;
            this.btnCopyProperties.Click += new System.EventHandler(this.btnCopyProperties_Click);
            // 
            // tileProperties
            // 
            this.tileProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileProperties.Location = new System.Drawing.Point(3, 112);
            this.tileProperties.Name = "tileProperties";
            this.tileProperties.Size = new System.Drawing.Size(617, 422);
            this.tileProperties.TabIndex = 0;
            this.tileProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.tileProperties_PropertyValueChanged);
            this.tileProperties.SelectedObjectsChanged += new System.EventHandler(this.tileProperties_SelectedObjectsChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            // 
            // pnlMain.Panel1
            // 
            this.pnlMain.Panel1.Controls.Add(this.pnlTileset);
            this.pnlMain.Panel1.Controls.Add(this.pnlBase);
            // 
            // pnlMain.Panel2
            // 
            this.pnlMain.Panel2.Controls.Add(this.tabMain);
            this.pnlMain.Panel2.Controls.Add(this.pnlFilter);
            this.pnlMain.Size = new System.Drawing.Size(1099, 621);
            this.pnlMain.SplitterDistance = 464;
            this.pnlMain.TabIndex = 3;
            // 
            // pnlTileset
            // 
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(0, 0);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.RectangleType = Editor.DrawRectangleType.None;
            this.pnlTileset.SelectionMode = Editor.SelectionMode.Multi;
            this.pnlTileset.Size = new System.Drawing.Size(464, 488);
            this.pnlTileset.TabIndex = 0;
            this.pnlTileset.Load += new System.EventHandler(this.pnlTileset_Load);
            // 
            // pnlBase
            // 
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.Location = new System.Drawing.Point(0, 488);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.RectangleType = Editor.DrawRectangleType.ShiftDrag;
            this.pnlBase.SelectionMode = Editor.SelectionMode.None;
            this.pnlBase.Size = new System.Drawing.Size(464, 133);
            this.pnlBase.TabIndex = 1;
            this.pnlBase.Load += new System.EventHandler(this.pnlBase_Load);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 58);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(631, 563);
            this.tabMain.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tileProperties);
            this.tabPage1.Controls.Add(this.pnlProperties);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Properties";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.btnCopyFromSelected);
            this.pnlProperties.Controls.Add(this.chkProperties);
            this.pnlProperties.Controls.Add(this.btnCopyProperties);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProperties.Location = new System.Drawing.Point(3, 3);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(617, 109);
            this.pnlProperties.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGroupTogether);
            this.tabPage2.Controls.Add(this.btnAutoOrganize);
            this.tabPage2.Controls.Add(this.btnAutoDetectSides);
            this.tabPage2.Controls.Add(this.txtDblClickGroup);
            this.tabPage2.Controls.Add(this.pnlGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAutoOrganize
            // 
            this.btnAutoOrganize.Location = new System.Drawing.Point(393, 123);
            this.btnAutoOrganize.Name = "btnAutoOrganize";
            this.btnAutoOrganize.Size = new System.Drawing.Size(160, 31);
            this.btnAutoOrganize.TabIndex = 13;
            this.btnAutoOrganize.Text = "Auto Organize";
            this.btnAutoOrganize.UseVisualStyleBackColor = true;
            this.btnAutoOrganize.Click += new System.EventHandler(this.btnAutoOrganize_Click);
            // 
            // btnAutoDetectSides
            // 
            this.btnAutoDetectSides.Location = new System.Drawing.Point(393, 74);
            this.btnAutoDetectSides.Name = "btnAutoDetectSides";
            this.btnAutoDetectSides.Size = new System.Drawing.Size(160, 31);
            this.btnAutoDetectSides.TabIndex = 12;
            this.btnAutoDetectSides.Text = "Auto Detect";
            this.btnAutoDetectSides.UseVisualStyleBackColor = true;
            this.btnAutoDetectSides.Click += new System.EventHandler(this.btnAutoDetectSides_Click);
            // 
            // txtDblClickGroup
            // 
            this.txtDblClickGroup.Location = new System.Drawing.Point(393, 6);
            this.txtDblClickGroup.MainGroup = null;
            this.txtDblClickGroup.Name = "txtDblClickGroup";
            this.txtDblClickGroup.Names = new string[0];
            this.txtDblClickGroup.Size = new System.Drawing.Size(160, 62);
            this.txtDblClickGroup.TabIndex = 11;
            // 
            // pnlGroupBox
            // 
            this.pnlGroupBox.Controls.Add(this.txtGroupLeftTop);
            this.pnlGroupBox.Controls.Add(this.txtGroupBottomRight);
            this.pnlGroupBox.Controls.Add(this.pnlTilePreview);
            this.pnlGroupBox.Controls.Add(this.txtGroupBottomLeft);
            this.pnlGroupBox.Controls.Add(this.txtGroupLeftBottom);
            this.pnlGroupBox.Controls.Add(this.txtGroupTopRight);
            this.pnlGroupBox.Controls.Add(this.txtGroupRightTop);
            this.pnlGroupBox.Controls.Add(this.txtGroupTopLeft);
            this.pnlGroupBox.Controls.Add(this.txtGroupRightBottom);
            this.pnlGroupBox.Location = new System.Drawing.Point(8, 6);
            this.pnlGroupBox.Name = "pnlGroupBox";
            this.pnlGroupBox.Size = new System.Drawing.Size(379, 351);
            this.pnlGroupBox.TabIndex = 10;
            // 
            // txtGroupLeftTop
            // 
            this.txtGroupLeftTop.Location = new System.Drawing.Point(14, 52);
            this.txtGroupLeftTop.MainGroup = null;
            this.txtGroupLeftTop.Name = "txtGroupLeftTop";
            this.txtGroupLeftTop.Names = new string[0];
            this.txtGroupLeftTop.Size = new System.Drawing.Size(78, 49);
            this.txtGroupLeftTop.TabIndex = 7;
            // 
            // txtGroupBottomRight
            // 
            this.txtGroupBottomRight.Location = new System.Drawing.Point(182, 236);
            this.txtGroupBottomRight.MainGroup = null;
            this.txtGroupBottomRight.Name = "txtGroupBottomRight";
            this.txtGroupBottomRight.Names = new string[0];
            this.txtGroupBottomRight.Size = new System.Drawing.Size(78, 49);
            this.txtGroupBottomRight.TabIndex = 4;
            // 
            // pnlTilePreview
            // 
            this.pnlTilePreview.Location = new System.Drawing.Point(98, 68);
            this.pnlTilePreview.Name = "pnlTilePreview";
            this.pnlTilePreview.Size = new System.Drawing.Size(162, 162);
            this.pnlTilePreview.TabIndex = 0;
            this.pnlTilePreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTilePreview_Paint);
            // 
            // txtGroupBottomLeft
            // 
            this.txtGroupBottomLeft.Location = new System.Drawing.Point(98, 236);
            this.txtGroupBottomLeft.MainGroup = null;
            this.txtGroupBottomLeft.Name = "txtGroupBottomLeft";
            this.txtGroupBottomLeft.Names = new string[0];
            this.txtGroupBottomLeft.Size = new System.Drawing.Size(78, 49);
            this.txtGroupBottomLeft.TabIndex = 5;
            // 
            // txtGroupLeftBottom
            // 
            this.txtGroupLeftBottom.Location = new System.Drawing.Point(14, 181);
            this.txtGroupLeftBottom.MainGroup = null;
            this.txtGroupLeftBottom.Name = "txtGroupLeftBottom";
            this.txtGroupLeftBottom.Names = new string[0];
            this.txtGroupLeftBottom.Size = new System.Drawing.Size(78, 49);
            this.txtGroupLeftBottom.TabIndex = 6;
            // 
            // txtGroupTopRight
            // 
            this.txtGroupTopRight.Location = new System.Drawing.Point(182, 13);
            this.txtGroupTopRight.MainGroup = null;
            this.txtGroupTopRight.Name = "txtGroupTopRight";
            this.txtGroupTopRight.Names = new string[0];
            this.txtGroupTopRight.Size = new System.Drawing.Size(78, 49);
            this.txtGroupTopRight.TabIndex = 1;
            // 
            // txtGroupRightTop
            // 
            this.txtGroupRightTop.Location = new System.Drawing.Point(266, 52);
            this.txtGroupRightTop.MainGroup = null;
            this.txtGroupRightTop.Name = "txtGroupRightTop";
            this.txtGroupRightTop.Names = new string[0];
            this.txtGroupRightTop.Size = new System.Drawing.Size(78, 49);
            this.txtGroupRightTop.TabIndex = 2;
            // 
            // txtGroupTopLeft
            // 
            this.txtGroupTopLeft.Location = new System.Drawing.Point(98, 13);
            this.txtGroupTopLeft.MainGroup = null;
            this.txtGroupTopLeft.Name = "txtGroupTopLeft";
            this.txtGroupTopLeft.Names = new string[0];
            this.txtGroupTopLeft.Size = new System.Drawing.Size(78, 49);
            this.txtGroupTopLeft.TabIndex = 0;
            // 
            // txtGroupRightBottom
            // 
            this.txtGroupRightBottom.Location = new System.Drawing.Point(266, 181);
            this.txtGroupRightBottom.MainGroup = null;
            this.txtGroupRightBottom.Name = "txtGroupRightBottom";
            this.txtGroupRightBottom.Names = new string[0];
            this.txtGroupRightBottom.Size = new System.Drawing.Size(78, 49);
            this.txtGroupRightBottom.TabIndex = 3;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.txtGroup);
            this.pnlFilter.Controls.Add(this.chkFilterExclusive);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(631, 58);
            this.pnlFilter.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btnGroupTogether
            // 
            this.btnGroupTogether.Location = new System.Drawing.Point(393, 176);
            this.btnGroupTogether.Name = "btnGroupTogether";
            this.btnGroupTogether.Size = new System.Drawing.Size(160, 31);
            this.btnGroupTogether.TabIndex = 14;
            this.btnGroupTogether.Text = "Group Together";
            this.btnGroupTogether.UseVisualStyleBackColor = true;
            this.btnGroupTogether.Click += new System.EventHandler(this.btnGroupTogether_Click);
            // 
            // TilesetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 645);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TilesetEditor";
            this.Text = "Tileset";
            this.Load += new System.EventHandler(this.TilesetEditor_Load);
            this.Resize += new System.EventHandler(this.TilesetEditor_Resize);
            this.pnlMain.Panel1.ResumeLayout(false);
            this.pnlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlProperties.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlGroupBox.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TilePanelUserControl pnlTileset;
        private TilePanelUserControl pnlBase;
        private System.Windows.Forms.Button btnCopyProperties;
        private System.Windows.Forms.PropertyGrid tileProperties;
        private System.Windows.Forms.CheckedListBox chkProperties;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCopyFromSelected;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.CheckBox chkFilterExclusive;
        private System.Windows.Forms.Panel pnlTilePreview;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.SplitContainer pnlMain;
        private System.Windows.Forms.Panel pnlGroupBox;
        private TileGroupAdder txtGroupLeftTop;
        private TileGroupAdder txtGroupBottomRight;
        private TileGroupAdder txtGroupBottomLeft;
        private TileGroupAdder txtGroupLeftBottom;
        private TileGroupAdder txtGroupTopRight;
        private TileGroupAdder txtGroupRightTop;
        private TileGroupAdder txtGroupTopLeft;
        private TileGroupAdder txtGroupRightBottom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private TileGroupAdder txtDblClickGroup;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAutoDetectSides;
        private System.Windows.Forms.Button btnAutoOrganize;
        private System.Windows.Forms.Button btnGroupTogether;



    }
}