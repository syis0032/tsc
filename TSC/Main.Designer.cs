namespace TSC
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStrip = new System.Windows.Forms.StatusStrip();
            this.lb_fps = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hitlable = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_diff = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainSplit1 = new System.Windows.Forms.SplitContainer();
            this.mainSplit2 = new System.Windows.Forms.SplitContainer();
            this.mainSplit3 = new System.Windows.Forms.SplitContainer();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.mainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit1)).BeginInit();
            this.mainSplit1.Panel2.SuspendLayout();
            this.mainSplit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit2)).BeginInit();
            this.mainSplit2.Panel2.SuspendLayout();
            this.mainSplit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit3)).BeginInit();
            this.mainSplit3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1122, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphicToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // graphicToolStripMenuItem
            // 
            this.graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            this.graphicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graphicToolStripMenuItem.Text = "&Graphic";
            this.graphicToolStripMenuItem.Click += new System.EventHandler(this.graphicToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "&Mode";
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.objectToolStripMenuItem.Text = "&Object";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineGuideToolStripMenuItem,
            this.homepageToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // onlineGuideToolStripMenuItem
            // 
            this.onlineGuideToolStripMenuItem.Name = "onlineGuideToolStripMenuItem";
            this.onlineGuideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onlineGuideToolStripMenuItem.Text = "&Online Guide";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homepageToolStripMenuItem.Text = "&Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "&About";
            // 
            // mainStrip
            // 
            this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_fps,
            this.Hitlable,
            this.lb_diff});
            this.mainStrip.Location = new System.Drawing.Point(0, 607);
            this.mainStrip.Name = "mainStrip";
            this.mainStrip.Size = new System.Drawing.Size(1122, 22);
            this.mainStrip.TabIndex = 1;
            this.mainStrip.Text = "mainStrip";
            // 
            // lb_fps
            // 
            this.lb_fps.Name = "lb_fps";
            this.lb_fps.Size = new System.Drawing.Size(34, 17);
            this.lb_fps.Text = "- FPS";
            // 
            // Hitlable
            // 
            this.Hitlable.Name = "Hitlable";
            this.Hitlable.Size = new System.Drawing.Size(13, 17);
            this.Hitlable.Text = "0";
            // 
            // lb_diff
            // 
            this.lb_diff.Name = "lb_diff";
            this.lb_diff.Size = new System.Drawing.Size(26, 17);
            this.lb_diff.Text = "Diff";
            // 
            // mainSplit1
            // 
            this.mainSplit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit1.Location = new System.Drawing.Point(0, 24);
            this.mainSplit1.Name = "mainSplit1";
            // 
            // mainSplit1.Panel2
            // 
            this.mainSplit1.Panel2.Controls.Add(this.mainSplit2);
            this.mainSplit1.Size = new System.Drawing.Size(1122, 583);
            this.mainSplit1.SplitterDistance = 766;
            this.mainSplit1.SplitterWidth = 1;
            this.mainSplit1.TabIndex = 2;
            // 
            // mainSplit2
            // 
            this.mainSplit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit2.Location = new System.Drawing.Point(0, 0);
            this.mainSplit2.Name = "mainSplit2";
            this.mainSplit2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplit2.Panel1
            // 
            this.mainSplit2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // mainSplit2.Panel2
            // 
            this.mainSplit2.Panel2.Controls.Add(this.mainSplit3);
            this.mainSplit2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainSplit2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainSplit2.Size = new System.Drawing.Size(355, 583);
            this.mainSplit2.SplitterDistance = 105;
            this.mainSplit2.SplitterWidth = 1;
            this.mainSplit2.TabIndex = 0;
            // 
            // mainSplit3
            // 
            this.mainSplit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit3.Location = new System.Drawing.Point(0, 0);
            this.mainSplit3.Name = "mainSplit3";
            this.mainSplit3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.mainSplit3.Size = new System.Drawing.Size(355, 477);
            this.mainSplit3.SplitterDistance = 327;
            this.mainSplit3.SplitterWidth = 1;
            this.mainSplit3.TabIndex = 0;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 30;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 629);
            this.Controls.Add(this.mainSplit1);
            this.Controls.Add(this.mainStrip);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.Text = "TSC v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainStrip.ResumeLayout(false);
            this.mainStrip.PerformLayout();
            this.mainSplit1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit1)).EndInit();
            this.mainSplit1.ResumeLayout(false);
            this.mainSplit2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit2)).EndInit();
            this.mainSplit2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit3)).EndInit();
            this.mainSplit3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplit1;
        private System.Windows.Forms.SplitContainer mainSplit2;
        private System.Windows.Forms.SplitContainer mainSplit3;
        private System.Windows.Forms.Timer mainTimer;
        public System.Windows.Forms.ToolStripStatusLabel lb_fps;
        public System.Windows.Forms.ToolStripStatusLabel Hitlable;
        public System.Windows.Forms.ToolStripStatusLabel lb_diff;
    }
}

