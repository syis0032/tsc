namespace TSC.View
{
    partial class ObjectSubControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectMenu = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectSplit = new System.Windows.Forms.SplitContainer();
            this.listBox_object = new System.Windows.Forms.ListBox();
            this.openFileSTL = new System.Windows.Forms.OpenFileDialog();
            this.saveFileSTL = new System.Windows.Forms.SaveFileDialog();
            this.objectMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectSplit)).BeginInit();
            this.objectSplit.Panel2.SuspendLayout();
            this.objectSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectMenu
            // 
            this.objectMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.arrayToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.objectMenu.Location = new System.Drawing.Point(0, 0);
            this.objectMenu.Name = "objectMenu";
            this.objectMenu.Size = new System.Drawing.Size(346, 24);
            this.objectMenu.TabIndex = 0;
            this.objectMenu.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // arrayToolStripMenuItem
            // 
            this.arrayToolStripMenuItem.Name = "arrayToolStripMenuItem";
            this.arrayToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.arrayToolStripMenuItem.Text = "Array";
            this.arrayToolStripMenuItem.Click += new System.EventHandler(this.arrayToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // objectSplit
            // 
            this.objectSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectSplit.IsSplitterFixed = true;
            this.objectSplit.Location = new System.Drawing.Point(0, 24);
            this.objectSplit.Name = "objectSplit";
            this.objectSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // objectSplit.Panel2
            // 
            this.objectSplit.Panel2.Controls.Add(this.listBox_object);
            this.objectSplit.Size = new System.Drawing.Size(346, 402);
            this.objectSplit.SplitterDistance = 111;
            this.objectSplit.SplitterWidth = 1;
            this.objectSplit.TabIndex = 1;
            // 
            // listBox_object
            // 
            this.listBox_object.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_object.FormattingEnabled = true;
            this.listBox_object.ItemHeight = 12;
            this.listBox_object.Location = new System.Drawing.Point(0, 0);
            this.listBox_object.Name = "listBox_object";
            this.listBox_object.Size = new System.Drawing.Size(346, 290);
            this.listBox_object.TabIndex = 0;
            this.listBox_object.SelectedIndexChanged += new System.EventHandler(this.listBox_object_SelectedIndexChanged);
            // 
            // openFileSTL
            // 
            this.openFileSTL.DefaultExt = "stl";
            this.openFileSTL.Filter = "STL|*.stl;*.STL";
            this.openFileSTL.Multiselect = true;
            this.openFileSTL.Title = "Load STL";
            // 
            // saveFileSTL
            // 
            this.saveFileSTL.DefaultExt = "stl";
            this.saveFileSTL.Filter = "STL|*.stl;*.STL";
            this.saveFileSTL.Title = "Save STL";
            // 
            // ObjectSubControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectSplit);
            this.Controls.Add(this.objectMenu);
            this.Name = "ObjectSubControl";
            this.Size = new System.Drawing.Size(346, 426);
            this.objectMenu.ResumeLayout(false);
            this.objectMenu.PerformLayout();
            this.objectSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectSplit)).EndInit();
            this.objectSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip objectMenu;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.SplitContainer objectSplit;
        private System.Windows.Forms.OpenFileDialog openFileSTL;
        private System.Windows.Forms.SaveFileDialog saveFileSTL;
        public System.Windows.Forms.ListBox listBox_object;
    }
}
