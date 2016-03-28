using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSC.Class;
using TSC.View.Utils;
using System.IO;
using OpenTK;

namespace TSC.View
{
    public partial class ObjectSubControl : UserControl
    {
        public GraphicView view;
        public ObjectInfo oinfo;
        public ObjCopy oCopy;

        public ObjectSubControl()
        {
            InitializeComponent();
            view = Main.main.graphicView;
            oinfo = new ObjectInfo();
            oCopy = new ObjCopy();

            oinfo.Dock = DockStyle.Fill;
            oCopy.Dock = DockStyle.Fill;
            objectSplit.Panel1.Controls.Add(oinfo);

        }

        public void SetInfoControl()
        {
            objectSplit.Panel1.Controls.Clear();
            objectSplit.Panel1.Controls.Add(oinfo);
        }

        private void ObjectAdd(string file)
        {
            STL stl = new STL();
            stl.Load(file);
            stl.InitPos();
            if (stl.list.Count > 0)
            {
                listBox_object.Items.Add(stl);
                view.models.AddLast(stl);
                listBox_object.SelectedItem = stl;
            }
        }
        public void ObjectSave(string fname)
        {
            int n = 0;
            foreach (STL stl in listBox_object.Items)
            {
                n += stl.list.Count;
            }
            STLTriangle[] triList2 = new STLTriangle[n];
            int p = 0;
            foreach (STL stl in listBox_object.Items)
            {
                stl.UpdateMatrix();
                foreach (STLTriangle t2 in stl.list)
                {
                    STLTriangle t = new STLTriangle();
                    t.p1 = new Vector3();
                    t.p2 = new Vector3();
                    t.p3 = new Vector3();
                    t.normal = new Vector3();
                    stl.TransformPoint(ref t2.p1, out t.p1.X, out t.p1.Y, out t.p1.Z);
                    stl.TransformPoint(ref t2.p2, out t.p2.X, out t.p2.Y, out t.p2.Z);
                    stl.TransformPoint(ref t2.p3, out t.p3.X, out t.p3.Y, out t.p3.Z);
                    float ax = t.p2.X - t.p1.X;
                    float ay = t.p2.Y - t.p1.Y;
                    float az = t.p2.Z - t.p1.Z;
                    float bx = t.p3.X - t.p1.X;
                    float by = t.p3.Y - t.p1.Y;
                    float bz = t.p3.Z - t.p1.Z;
                    t.normal.X = ay * bz - az * by;
                    t.normal.Y = az * bx - ax * bz;
                    t.normal.Z = ax * by - ay * bx;
                    Vector3.Normalize(ref t.normal, out t.normal);
                    triList2[p++] = t;
                }
            }
            n = p;
            STLTriangle[] triList = new STLTriangle[n];
            for (int i = 0; i < n; i++)
                triList[i] = triList2[i];

            Array.Sort<STLTriangle>(triList, triList[0]);

            FileStream fs = File.Open(fname, FileMode.Create);

            BinaryWriter w = new BinaryWriter(fs);
            int j;
            for (j = 0; j < 20; j++) w.Write((int)0);
            w.Write(n);
            for (j = 0; j < n; j++)
            {
                STLTriangle t = triList[j];
                w.Write(t.normal.X);
                w.Write(t.normal.Y);
                w.Write(t.normal.Z);
                w.Write(t.p1.X);
                w.Write(t.p1.Y);
                w.Write(t.p1.Z);
                w.Write(t.p2.X);
                w.Write(t.p2.Y);
                w.Write(t.p2.Z);
                w.Write(t.p3.X);
                w.Write(t.p3.Y);
                w.Write(t.p3.Z);
                w.Write((short)0);
            }
            w.Close();
            fs.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_object.Items.Count == 0) return;
            if (saveFileSTL.ShowDialog() == DialogResult.OK)
            {
                ObjectSave(saveFileSTL.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileSTL.ShowDialog() == DialogResult.OK)
            {
                foreach (string fname in openFileSTL.FileNames)
                {
                    ObjectAdd(fname);
                    Main.main.logBox.Add(new LogLine(Path.GetFileNameWithoutExtension(fname) + " Loaded", false, 2));
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objectSplit.Panel1.Controls.Clear();
            objectSplit.Panel1.Controls.Add(oCopy);
        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox_object_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main.main.graphicControl.UpdateGLView();
            if (listBox_object.SelectedItems.Count == 1)
            {
                STL stl = (STL)listBox_object.SelectedItem;
                oinfo.lb_obXpos.Text = stl.Position.x.ToString("F3");
                oinfo.lb_obYpos.Text = stl.Position.y.ToString("F3");
                oinfo.lb_obZpos.Text = stl.Position.z.ToString("F3");
            }
            else
            {
                if (listBox_object.Items.Count != 0)
                {
                    listBox_object.SetSelected(0, true);
                    return;
                }
                oinfo.lb_obXpos.Text = "-";
                oinfo.lb_obYpos.Text = "-";
                oinfo.lb_obZpos.Text = "-";
            }
        }
    }
}
