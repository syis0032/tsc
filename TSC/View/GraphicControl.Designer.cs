namespace TSC.View
{
    partial class GraphicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicControl));
            this.toolStrip_graphic = new System.Windows.Forms.ToolStrip();
            this.toolSB_front = new System.Windows.Forms.ToolStripButton();
            this.toolSB_back = new System.Windows.Forms.ToolStripButton();
            this.toolSB_left = new System.Windows.Forms.ToolStripButton();
            this.toolSB_right = new System.Windows.Forms.ToolStripButton();
            this.toolSB_top = new System.Windows.Forms.ToolStripButton();
            this.toolSB_bottom = new System.Windows.Forms.ToolStripButton();
            this.toolSB_reset = new System.Windows.Forms.ToolStripButton();
            this.gl = new TSC.View.Utils.OpenGL();
            this.lb_GridSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_graphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_graphic
            // 
            this.toolStrip_graphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip_graphic.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_graphic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSB_front,
            this.toolSB_back,
            this.toolSB_left,
            this.toolSB_right,
            this.toolSB_top,
            this.toolSB_bottom,
            this.toolSB_reset,
            this.lb_GridSize});
            this.toolStrip_graphic.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_graphic.Name = "toolStrip_graphic";
            this.toolStrip_graphic.Size = new System.Drawing.Size(52, 474);
            this.toolStrip_graphic.TabIndex = 0;
            // 
            // toolSB_front
            // 
            this.toolSB_front.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_front.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_front.Image")));
            this.toolSB_front.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_front.Name = "toolSB_front";
            this.toolSB_front.Size = new System.Drawing.Size(49, 19);
            this.toolSB_front.Text = "Front";
            this.toolSB_front.Click += new System.EventHandler(this.toolSB_front_Click);
            // 
            // toolSB_back
            // 
            this.toolSB_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_back.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_back.Image")));
            this.toolSB_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_back.Name = "toolSB_back";
            this.toolSB_back.Size = new System.Drawing.Size(49, 19);
            this.toolSB_back.Text = "Back";
            this.toolSB_back.Click += new System.EventHandler(this.toolSB_back_Click);
            // 
            // toolSB_left
            // 
            this.toolSB_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_left.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_left.Image")));
            this.toolSB_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_left.Name = "toolSB_left";
            this.toolSB_left.Size = new System.Drawing.Size(49, 19);
            this.toolSB_left.Text = "Left";
            this.toolSB_left.Click += new System.EventHandler(this.toolSB_left_Click);
            // 
            // toolSB_right
            // 
            this.toolSB_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_right.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_right.Image")));
            this.toolSB_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_right.Name = "toolSB_right";
            this.toolSB_right.Size = new System.Drawing.Size(49, 19);
            this.toolSB_right.Text = "Right";
            this.toolSB_right.Click += new System.EventHandler(this.toolSB_right_Click);
            // 
            // toolSB_top
            // 
            this.toolSB_top.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_top.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_top.Image")));
            this.toolSB_top.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_top.Name = "toolSB_top";
            this.toolSB_top.Size = new System.Drawing.Size(49, 19);
            this.toolSB_top.Text = "Top";
            this.toolSB_top.Click += new System.EventHandler(this.toolSB_top_Click);
            // 
            // toolSB_bottom
            // 
            this.toolSB_bottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_bottom.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_bottom.Image")));
            this.toolSB_bottom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_bottom.Name = "toolSB_bottom";
            this.toolSB_bottom.Size = new System.Drawing.Size(49, 19);
            this.toolSB_bottom.Text = "Bottom";
            this.toolSB_bottom.Click += new System.EventHandler(this.toolSB_bottom_Click);
            // 
            // toolSB_reset
            // 
            this.toolSB_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSB_reset.Image = ((System.Drawing.Image)(resources.GetObject("toolSB_reset.Image")));
            this.toolSB_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSB_reset.Name = "toolSB_reset";
            this.toolSB_reset.Size = new System.Drawing.Size(49, 19);
            this.toolSB_reset.Text = "Reset";
            this.toolSB_reset.Click += new System.EventHandler(this.toolSB_reset_Click);
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gl.Location = new System.Drawing.Point(52, 0);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(642, 474);
            this.gl.TabIndex = 1;
            this.gl.VSync = false;
            this.gl.Load += new System.EventHandler(this.gl_Load);
            this.gl.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_Paint);
            this.gl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gl_MouseDown);
            this.gl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gl_MouseMove);
            this.gl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gl_MouseUp);
            // 
            // lb_GridSize
            // 
            this.lb_GridSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lb_GridSize.Name = "lb_GridSize";
            this.lb_GridSize.Size = new System.Drawing.Size(49, 15);
            this.lb_GridSize.Text = "-";
            // 
            // GraphicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gl);
            this.Controls.Add(this.toolStrip_graphic);
            this.Name = "GraphicControl";
            this.Size = new System.Drawing.Size(694, 474);
            this.toolStrip_graphic.ResumeLayout(false);
            this.toolStrip_graphic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolSB_front;
        private System.Windows.Forms.ToolStripButton toolSB_back;
        private System.Windows.Forms.ToolStripButton toolSB_left;
        private System.Windows.Forms.ToolStripButton toolSB_right;
        private System.Windows.Forms.ToolStripButton toolSB_top;
        private System.Windows.Forms.ToolStripButton toolSB_bottom;
        private System.Windows.Forms.ToolStripButton toolSB_reset;
        private Utils.OpenGL gl;
        protected System.Windows.Forms.ToolStrip toolStrip_graphic;
        private System.Windows.Forms.ToolStripLabel lb_GridSize;
        
    }
}
