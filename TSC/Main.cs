using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TSC.View;
using TSC.Class;
using TSC.View.Utils;
using System.Threading;

namespace TSC
{
    public partial class Main : Form
    {
        public static Main main = null;
        public static BasicConfig basicConfig = null;
        public static GraphicConfig graphicConfig = null;

        public GraphicControl graphicControl = null;
        public ModeControl modeControl = null;
        public GraphicView graphicView = null;
        public GraphicView jobPreview = null;
        public GraphicView printPreview = null; 
        public LogBox logBox = null;
        public ObjectSubControl objectSubControl = null;

        public Main()
        {
            InitializeComponent();
            main = this;
            basicConfig = new BasicConfig();
            graphicConfig = new GraphicConfig();
            modeControl = new ModeControl();
            logBox = new LogBox();
            graphicView = new GraphicView();
            jobPreview = new GraphicView();
            printPreview = new GraphicView();
            objectSubControl = new ObjectSubControl();
            graphicControl = new GraphicControl();

            graphicControl.Dock = DockStyle.Fill;
            objectSubControl.Dock = DockStyle.Fill;
            modeChanger();

            modeControl.Dock = DockStyle.Fill;
            mainSplit2.Panel1.Controls.Add(modeControl);

            
            

            logBox.Dock = DockStyle.Fill;
            mainSplit3.Panel2.Controls.Add(logBox);

        }

        public void modeChanger()
        {
            mainSplit1.Panel1.Controls.Clear();
            mainSplit3.Panel1.Controls.Clear();
            graphicControl.SetView(graphicView);
            mainSplit1.Panel1.Controls.Add(graphicControl);
            mainSplit3.Panel1.Controls.Add(objectSubControl);
            modeControl.lb_mode.Text = "OBJECT";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            graphicControl.Application_Idle();
            logBox.UpdateLog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainTimer.Start();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void graphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphicConfig.Show();
            graphicConfig.BringToFront();
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
