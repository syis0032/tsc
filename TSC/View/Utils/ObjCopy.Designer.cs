namespace TSC.View.Utils
{
    partial class ObjCopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericCopies = new System.Windows.Forms.NumericUpDown();
            this.cb_autoPos = new System.Windows.Forms.CheckBox();
            this.btn_retunControl = new System.Windows.Forms.Button();
            this.btn_copyDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Copies";
            // 
            // numericCopies
            // 
            this.numericCopies.Location = new System.Drawing.Point(163, 10);
            this.numericCopies.Name = "numericCopies";
            this.numericCopies.Size = new System.Drawing.Size(56, 21);
            this.numericCopies.TabIndex = 1;
            this.numericCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_autoPos
            // 
            this.cb_autoPos.AutoSize = true;
            this.cb_autoPos.Checked = true;
            this.cb_autoPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoPos.Location = new System.Drawing.Point(40, 38);
            this.cb_autoPos.Name = "cb_autoPos";
            this.cb_autoPos.Size = new System.Drawing.Size(98, 16);
            this.cb_autoPos.TabIndex = 2;
            this.cb_autoPos.Text = "Auto Position";
            this.cb_autoPos.UseVisualStyleBackColor = true;
            // 
            // btn_retunControl
            // 
            this.btn_retunControl.Location = new System.Drawing.Point(3, 3);
            this.btn_retunControl.Name = "btn_retunControl";
            this.btn_retunControl.Size = new System.Drawing.Size(20, 23);
            this.btn_retunControl.TabIndex = 3;
            this.btn_retunControl.Text = "X";
            this.btn_retunControl.UseVisualStyleBackColor = true;
            this.btn_retunControl.Click += new System.EventHandler(this.btn_retunControl_Click);
            // 
            // btn_copyDone
            // 
            this.btn_copyDone.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_copyDone.Location = new System.Drawing.Point(163, 35);
            this.btn_copyDone.Name = "btn_copyDone";
            this.btn_copyDone.Size = new System.Drawing.Size(56, 23);
            this.btn_copyDone.TabIndex = 4;
            this.btn_copyDone.Text = "Copy";
            this.btn_copyDone.UseVisualStyleBackColor = true;
            this.btn_copyDone.Click += new System.EventHandler(this.btn_copyDone_Click);
            // 
            // ObjCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_copyDone);
            this.Controls.Add(this.btn_retunControl);
            this.Controls.Add(this.cb_autoPos);
            this.Controls.Add(this.numericCopies);
            this.Controls.Add(this.label1);
            this.Name = "ObjCopy";
            this.Size = new System.Drawing.Size(257, 77);
            ((System.ComponentModel.ISupportInitialize)(this.numericCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericCopies;
        public System.Windows.Forms.CheckBox cb_autoPos;
        private System.Windows.Forms.Button btn_retunControl;
        private System.Windows.Forms.Button btn_copyDone;
    }
}
