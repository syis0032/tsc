using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TSC.View.Utils
{
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.Selectable, true);

            this.UpdateStyles();
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            return true;
            //return base.ProcessKeyPreview(ref m);
        }
        protected override bool IsInputKey(System.Windows.Forms.Keys keyData)
        {
            return true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DoubleBufferPanel
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ResumeLayout(false);
        }
    }
}
