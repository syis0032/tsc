using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSC.View
{
    public partial class GraphicConfig : Form
    {
        public int drawMethod = 0;
        public float openGLVer = 1.0f;
        public bool renderSupport = false;

        public GraphicConfig()
        {
            InitializeComponent();
            cbBoxDrawMethod.SelectedIndex = 0;
            cbBoxDrawQuality.SelectedIndex = 1;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void leftWall_Click(object sender, EventArgs e)
        {
            colorDialog.Color = leftWall.BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                leftWall.BackColor = colorDialog.Color;
            }
        }

        private void backWall_Click(object sender, EventArgs e)
        {
            colorDialog.Color = backWall.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backWall.BackColor = colorDialog.Color;
            }
        }

        private void bottomWall_Click(object sender, EventArgs e)
        {
            colorDialog.Color = bottomWall.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                bottomWall.BackColor = colorDialog.Color;
            }
        }

        private void rightWall_Click(object sender, EventArgs e)
        {
            colorDialog.Color = rightWall.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rightWall.BackColor = colorDialog.Color;
            }
        }

        private void backGround_Click(object sender, EventArgs e)
        {
            colorDialog.Color = backGroundBot.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backGroundBot.BackColor = colorDialog.Color;
            }
        }

        private void grid_Click(object sender, EventArgs e)
        {
            colorDialog.Color = grid.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                grid.BackColor = colorDialog.Color;
            }
        }

        private void pathColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pathColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pathColor.BackColor = colorDialog.Color;
            }
        }

        private void travelColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = travelColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                travelColor.BackColor = colorDialog.Color;
            }
        }

        private void FaceColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = FaceColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                FaceColor.BackColor = colorDialog.Color;
            }
        }

        private void EdgeColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = EdgeColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                EdgeColor.BackColor = colorDialog.Color;
            }
        }

        private void SelFaceColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = SelFaceColor.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                SelFaceColor.BackColor = colorDialog.Color;
            }
        }
    }
}
