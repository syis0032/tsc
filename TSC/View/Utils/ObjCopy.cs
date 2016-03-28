using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSC.View.Utils
{
    public partial class ObjCopy : UserControl
    {
        public ObjCopy()
        {
            InitializeComponent();
        }

        private void btn_retunControl_Click(object sender, EventArgs e)
        {
            Main.main.objectSubControl.SetInfoControl();
        }

        private void btn_copyDone_Click(object sender, EventArgs e)
        {

        }
    }
}
