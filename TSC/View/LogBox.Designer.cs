namespace TSC.View
{
    partial class LogBox
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
            this.scroll = new System.Windows.Forms.VScrollBar();
            this.log = new TSC.View.Utils.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // scroll
            // 
            this.scroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll.Location = new System.Drawing.Point(532, 0);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(17, 280);
            this.scroll.TabIndex = 0;
            this.scroll.ValueChanged += new System.EventHandler(this.scroll_ValueChanged);
            // 
            // log
            // 
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.Location = new System.Drawing.Point(0, 0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(532, 280);
            this.log.TabIndex = 1;
            this.log.Paint += new System.Windows.Forms.PaintEventHandler(this.log_Paint);
            // 
            // LogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.log);
            this.Controls.Add(this.scroll);
            this.Name = "LogBox";
            this.Size = new System.Drawing.Size(549, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar scroll;
        private Utils.DoubleBufferPanel log;
    }
}
