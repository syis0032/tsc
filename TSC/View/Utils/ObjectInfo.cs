using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TSC.Class;

namespace TSC.View.Utils
{
    public partial class ObjectInfo : UserControl
    {
        GraphicView view = null;
        public ObjectInfo()
        {
            InitializeComponent();
            view = Main.main.graphicView;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            LinkedList<STL> list = new LinkedList<STL>();
            foreach (STL stl in Main.main.objectSubControl.listBox_object.SelectedItems)
                list.AddLast(stl);
            foreach (STL stl in list)
            {
                view.models.Remove(stl);
                Main.main.objectSubControl.listBox_object.Items.Remove(stl);
            }
            list.Clear();
        }
    }
}
