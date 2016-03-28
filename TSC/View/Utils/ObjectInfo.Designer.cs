namespace TSC.View.Utils
{
    partial class ObjectInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_obXpos = new System.Windows.Forms.Label();
            this.lb_obYpos = new System.Windows.Forms.Label();
            this.lb_obZpos = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lb_obZpos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_obYpos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_obXpos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_remove, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(101, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 108);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(199, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 108);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_obXpos
            // 
            this.lb_obXpos.AutoSize = true;
            this.lb_obXpos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_obXpos.Location = new System.Drawing.Point(3, 108);
            this.lb_obXpos.Name = "lb_obXpos";
            this.lb_obXpos.Size = new System.Drawing.Size(92, 108);
            this.lb_obXpos.TabIndex = 4;
            this.lb_obXpos.Text = "-";
            this.lb_obXpos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_obYpos
            // 
            this.lb_obYpos.AutoSize = true;
            this.lb_obYpos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_obYpos.Location = new System.Drawing.Point(101, 108);
            this.lb_obYpos.Name = "lb_obYpos";
            this.lb_obYpos.Size = new System.Drawing.Size(92, 108);
            this.lb_obYpos.TabIndex = 5;
            this.lb_obYpos.Text = "-";
            this.lb_obYpos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_obZpos
            // 
            this.lb_obZpos.AutoSize = true;
            this.lb_obZpos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_obZpos.Location = new System.Drawing.Point(199, 108);
            this.lb_obZpos.Name = "lb_obZpos";
            this.lb_obZpos.Size = new System.Drawing.Size(92, 108);
            this.lb_obZpos.TabIndex = 6;
            this.lb_obZpos.Text = "-";
            this.lb_obZpos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_remove
            // 
            this.btn_remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_remove.Location = new System.Drawing.Point(297, 111);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(93, 102);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // ObjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ObjectInfo";
            this.Size = new System.Drawing.Size(393, 216);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_remove;
        public System.Windows.Forms.Label lb_obZpos;
        public System.Windows.Forms.Label lb_obYpos;
        public System.Windows.Forms.Label lb_obXpos;
    }
}
