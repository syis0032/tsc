namespace TSC.View
{
    partial class GraphicConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.cb_gradient = new System.Windows.Forms.CheckBox();
            this.cb_ortho = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_light4 = new System.Windows.Forms.CheckBox();
            this.cb_light3 = new System.Windows.Forms.CheckBox();
            this.cb_light2 = new System.Windows.Forms.CheckBox();
            this.cb_light1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_gridColor = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.Panel();
            this.cb_gridYZ = new System.Windows.Forms.CheckBox();
            this.cb_gridXZ = new System.Windows.Forms.CheckBox();
            this.cb_gridXY = new System.Windows.Forms.CheckBox();
            this.cb_gridValue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericGrid = new System.Windows.Forms.NumericUpDown();
            this.cb_gridAuto = new System.Windows.Forms.CheckBox();
            this.cb_grid = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericAlpha = new System.Windows.Forms.NumericUpDown();
            this.cb_alpha = new System.Windows.Forms.CheckBox();
            this.lb_rightWall = new System.Windows.Forms.Label();
            this.lb_bottomWall = new System.Windows.Forms.Label();
            this.lb_backWall = new System.Windows.Forms.Label();
            this.lb_leftWall = new System.Windows.Forms.Label();
            this.rightWall = new System.Windows.Forms.Panel();
            this.bottomWall = new System.Windows.Forms.Panel();
            this.backWall = new System.Windows.Forms.Panel();
            this.leftWall = new System.Windows.Forms.Panel();
            this.cb_wall = new System.Windows.Forms.CheckBox();
            this.cb_zeroPoint = new System.Windows.Forms.CheckBox();
            this.cb_guide = new System.Windows.Forms.CheckBox();
            this.backGroundTop = new System.Windows.Forms.Panel();
            this.backGroundBot = new System.Windows.Forms.Panel();
            this.lb_backGround = new System.Windows.Forms.Label();
            this.tabModel = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_edges = new System.Windows.Forms.CheckBox();
            this.EdgeColor = new System.Windows.Forms.Panel();
            this.cb_faces = new System.Windows.Forms.CheckBox();
            this.FaceColor = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_heightAuto = new System.Windows.Forms.CheckBox();
            this.cb_thicknessAuto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericThickness = new System.Windows.Forms.NumericUpDown();
            this.lb_height = new System.Windows.Forms.Label();
            this.lb_thickness = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.travelColor = new System.Windows.Forms.Panel();
            this.pathColor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_travel = new System.Windows.Forms.CheckBox();
            this.cb_segment = new System.Windows.Forms.CheckBox();
            this.cbBoxDrawQuality = new System.Windows.Forms.ComboBox();
            this.cbBoxDrawMethod = new System.Windows.Forms.ComboBox();
            this.lb_method = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SelFaceColor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabView.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlpha)).BeginInit();
            this.tabModel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThickness)).BeginInit();
            this.pathColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabView);
            this.tabControl.Controls.Add(this.tabModel);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(589, 402);
            this.tabControl.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.cb_gradient);
            this.tabView.Controls.Add(this.cb_ortho);
            this.tabView.Controls.Add(this.groupBox5);
            this.tabView.Controls.Add(this.groupBox2);
            this.tabView.Controls.Add(this.groupBox1);
            this.tabView.Controls.Add(this.cb_zeroPoint);
            this.tabView.Controls.Add(this.cb_guide);
            this.tabView.Controls.Add(this.backGroundTop);
            this.tabView.Controls.Add(this.backGroundBot);
            this.tabView.Controls.Add(this.lb_backGround);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(581, 376);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // cb_gradient
            // 
            this.cb_gradient.AutoSize = true;
            this.cb_gradient.Checked = true;
            this.cb_gradient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gradient.Location = new System.Drawing.Point(365, 20);
            this.cb_gradient.Name = "cb_gradient";
            this.cb_gradient.Size = new System.Drawing.Size(71, 16);
            this.cb_gradient.TabIndex = 19;
            this.cb_gradient.Text = "Gradient";
            this.cb_gradient.UseVisualStyleBackColor = true;
            // 
            // cb_ortho
            // 
            this.cb_ortho.AutoSize = true;
            this.cb_ortho.Location = new System.Drawing.Point(269, 56);
            this.cb_ortho.Name = "cb_ortho";
            this.cb_ortho.Size = new System.Drawing.Size(128, 16);
            this.cb_ortho.TabIndex = 19;
            this.cb_ortho.Text = "Orthogonal Project";
            this.cb_ortho.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_light4);
            this.groupBox5.Controls.Add(this.cb_light3);
            this.groupBox5.Controls.Add(this.cb_light2);
            this.groupBox5.Controls.Add(this.cb_light1);
            this.groupBox5.Location = new System.Drawing.Point(6, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(559, 49);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Light";
            // 
            // cb_light4
            // 
            this.cb_light4.AutoSize = true;
            this.cb_light4.Location = new System.Drawing.Point(379, 22);
            this.cb_light4.Name = "cb_light4";
            this.cb_light4.Size = new System.Drawing.Size(61, 16);
            this.cb_light4.TabIndex = 0;
            this.cb_light4.Text = "Light 4";
            this.cb_light4.UseVisualStyleBackColor = true;
            // 
            // cb_light3
            // 
            this.cb_light3.AutoSize = true;
            this.cb_light3.Location = new System.Drawing.Point(278, 22);
            this.cb_light3.Name = "cb_light3";
            this.cb_light3.Size = new System.Drawing.Size(61, 16);
            this.cb_light3.TabIndex = 0;
            this.cb_light3.Text = "Light 3";
            this.cb_light3.UseVisualStyleBackColor = true;
            // 
            // cb_light2
            // 
            this.cb_light2.AutoSize = true;
            this.cb_light2.Checked = true;
            this.cb_light2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_light2.Location = new System.Drawing.Point(177, 22);
            this.cb_light2.Name = "cb_light2";
            this.cb_light2.Size = new System.Drawing.Size(61, 16);
            this.cb_light2.TabIndex = 0;
            this.cb_light2.Text = "Light 2";
            this.cb_light2.UseVisualStyleBackColor = true;
            // 
            // cb_light1
            // 
            this.cb_light1.AutoSize = true;
            this.cb_light1.Checked = true;
            this.cb_light1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_light1.Location = new System.Drawing.Point(76, 22);
            this.cb_light1.Name = "cb_light1";
            this.cb_light1.Size = new System.Drawing.Size(61, 16);
            this.cb_light1.TabIndex = 0;
            this.cb_light1.Text = "Light 1";
            this.cb_light1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_gridColor);
            this.groupBox2.Controls.Add(this.grid);
            this.groupBox2.Controls.Add(this.cb_gridYZ);
            this.groupBox2.Controls.Add(this.cb_gridXZ);
            this.groupBox2.Controls.Add(this.cb_gridXY);
            this.groupBox2.Controls.Add(this.cb_gridValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericGrid);
            this.groupBox2.Controls.Add(this.cb_gridAuto);
            this.groupBox2.Controls.Add(this.cb_grid);
            this.groupBox2.Location = new System.Drawing.Point(6, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid";
            // 
            // lb_gridColor
            // 
            this.lb_gridColor.AutoSize = true;
            this.lb_gridColor.Location = new System.Drawing.Point(289, 23);
            this.lb_gridColor.Name = "lb_gridColor";
            this.lb_gridColor.Size = new System.Drawing.Size(70, 12);
            this.lb_gridColor.TabIndex = 15;
            this.lb_gridColor.Text = "Grid Color :";
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.Black;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid.Location = new System.Drawing.Point(366, 17);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(90, 25);
            this.grid.TabIndex = 14;
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // cb_gridYZ
            // 
            this.cb_gridYZ.AutoSize = true;
            this.cb_gridYZ.Location = new System.Drawing.Point(222, 22);
            this.cb_gridYZ.Name = "cb_gridYZ";
            this.cb_gridYZ.Size = new System.Drawing.Size(40, 16);
            this.cb_gridYZ.TabIndex = 13;
            this.cb_gridYZ.Text = "YZ";
            this.cb_gridYZ.UseVisualStyleBackColor = true;
            // 
            // cb_gridXZ
            // 
            this.cb_gridXZ.AutoSize = true;
            this.cb_gridXZ.Checked = true;
            this.cb_gridXZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gridXZ.Location = new System.Drawing.Point(168, 22);
            this.cb_gridXZ.Name = "cb_gridXZ";
            this.cb_gridXZ.Size = new System.Drawing.Size(40, 16);
            this.cb_gridXZ.TabIndex = 13;
            this.cb_gridXZ.Text = "XZ";
            this.cb_gridXZ.UseVisualStyleBackColor = true;
            // 
            // cb_gridXY
            // 
            this.cb_gridXY.AutoSize = true;
            this.cb_gridXY.Checked = true;
            this.cb_gridXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gridXY.Location = new System.Drawing.Point(114, 22);
            this.cb_gridXY.Name = "cb_gridXY";
            this.cb_gridXY.Size = new System.Drawing.Size(40, 16);
            this.cb_gridXY.TabIndex = 13;
            this.cb_gridXY.Text = "XY";
            this.cb_gridXY.UseVisualStyleBackColor = true;
            // 
            // cb_gridValue
            // 
            this.cb_gridValue.AutoSize = true;
            this.cb_gridValue.Checked = true;
            this.cb_gridValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gridValue.Location = new System.Drawing.Point(376, 60);
            this.cb_gridValue.Name = "cb_gridValue";
            this.cb_gridValue.Size = new System.Drawing.Size(119, 16);
            this.cb_gridValue.TabIndex = 11;
            this.cb_gridValue.Text = "Show Grid Value";
            this.cb_gridValue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "[mm]";
            // 
            // numericGrid
            // 
            this.numericGrid.Location = new System.Drawing.Point(112, 59);
            this.numericGrid.Name = "numericGrid";
            this.numericGrid.Size = new System.Drawing.Size(123, 21);
            this.numericGrid.TabIndex = 7;
            this.numericGrid.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cb_gridAuto
            // 
            this.cb_gridAuto.AutoSize = true;
            this.cb_gridAuto.Checked = true;
            this.cb_gridAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gridAuto.Location = new System.Drawing.Point(301, 61);
            this.cb_gridAuto.Name = "cb_gridAuto";
            this.cb_gridAuto.Size = new System.Drawing.Size(49, 16);
            this.cb_gridAuto.TabIndex = 6;
            this.cb_gridAuto.Text = "Auto";
            this.cb_gridAuto.UseVisualStyleBackColor = true;
            // 
            // cb_grid
            // 
            this.cb_grid.AutoSize = true;
            this.cb_grid.Checked = true;
            this.cb_grid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_grid.Location = new System.Drawing.Point(8, 23);
            this.cb_grid.Name = "cb_grid";
            this.cb_grid.Size = new System.Drawing.Size(91, 16);
            this.cb_grid.TabIndex = 5;
            this.cb_grid.Text = "Show Grid :";
            this.cb_grid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericAlpha);
            this.groupBox1.Controls.Add(this.cb_alpha);
            this.groupBox1.Controls.Add(this.lb_rightWall);
            this.groupBox1.Controls.Add(this.lb_bottomWall);
            this.groupBox1.Controls.Add(this.lb_backWall);
            this.groupBox1.Controls.Add(this.lb_leftWall);
            this.groupBox1.Controls.Add(this.rightWall);
            this.groupBox1.Controls.Add(this.bottomWall);
            this.groupBox1.Controls.Add(this.backWall);
            this.groupBox1.Controls.Add(this.leftWall);
            this.groupBox1.Controls.Add(this.cb_wall);
            this.groupBox1.Location = new System.Drawing.Point(5, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wall";
            // 
            // numericAlpha
            // 
            this.numericAlpha.Location = new System.Drawing.Point(218, 75);
            this.numericAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericAlpha.Name = "numericAlpha";
            this.numericAlpha.Size = new System.Drawing.Size(120, 21);
            this.numericAlpha.TabIndex = 10;
            this.numericAlpha.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cb_alpha
            // 
            this.cb_alpha.AutoSize = true;
            this.cb_alpha.Checked = true;
            this.cb_alpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_alpha.Location = new System.Drawing.Point(111, 77);
            this.cb_alpha.Name = "cb_alpha";
            this.cb_alpha.Size = new System.Drawing.Size(90, 16);
            this.cb_alpha.TabIndex = 9;
            this.cb_alpha.Text = "Use Alpha :";
            this.cb_alpha.UseVisualStyleBackColor = true;
            // 
            // lb_rightWall
            // 
            this.lb_rightWall.AutoSize = true;
            this.lb_rightWall.Location = new System.Drawing.Point(472, 15);
            this.lb_rightWall.Name = "lb_rightWall";
            this.lb_rightWall.Size = new System.Drawing.Size(33, 12);
            this.lb_rightWall.TabIndex = 4;
            this.lb_rightWall.Text = "Right";
            // 
            // lb_bottomWall
            // 
            this.lb_bottomWall.AutoSize = true;
            this.lb_bottomWall.Location = new System.Drawing.Point(358, 15);
            this.lb_bottomWall.Name = "lb_bottomWall";
            this.lb_bottomWall.Size = new System.Drawing.Size(44, 12);
            this.lb_bottomWall.TabIndex = 4;
            this.lb_bottomWall.Text = "Bottom";
            // 
            // lb_backWall
            // 
            this.lb_backWall.AutoSize = true;
            this.lb_backWall.Location = new System.Drawing.Point(247, 15);
            this.lb_backWall.Name = "lb_backWall";
            this.lb_backWall.Size = new System.Drawing.Size(33, 12);
            this.lb_backWall.TabIndex = 4;
            this.lb_backWall.Text = "Back";
            // 
            // lb_leftWall
            // 
            this.lb_leftWall.AutoSize = true;
            this.lb_leftWall.Location = new System.Drawing.Point(141, 15);
            this.lb_leftWall.Name = "lb_leftWall";
            this.lb_leftWall.Size = new System.Drawing.Size(25, 12);
            this.lb_leftWall.TabIndex = 4;
            this.lb_leftWall.Text = "Left";
            // 
            // rightWall
            // 
            this.rightWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.rightWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightWall.Location = new System.Drawing.Point(446, 34);
            this.rightWall.Name = "rightWall";
            this.rightWall.Size = new System.Drawing.Size(90, 25);
            this.rightWall.TabIndex = 3;
            this.rightWall.Click += new System.EventHandler(this.rightWall_Click);
            // 
            // bottomWall
            // 
            this.bottomWall.BackColor = System.Drawing.Color.Black;
            this.bottomWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomWall.Location = new System.Drawing.Point(335, 34);
            this.bottomWall.Name = "bottomWall";
            this.bottomWall.Size = new System.Drawing.Size(90, 25);
            this.bottomWall.TabIndex = 3;
            this.bottomWall.Click += new System.EventHandler(this.bottomWall_Click);
            // 
            // backWall
            // 
            this.backWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backWall.Location = new System.Drawing.Point(224, 34);
            this.backWall.Name = "backWall";
            this.backWall.Size = new System.Drawing.Size(90, 25);
            this.backWall.TabIndex = 3;
            this.backWall.Click += new System.EventHandler(this.backWall_Click);
            // 
            // leftWall
            // 
            this.leftWall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.leftWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftWall.Location = new System.Drawing.Point(113, 34);
            this.leftWall.Name = "leftWall";
            this.leftWall.Size = new System.Drawing.Size(90, 25);
            this.leftWall.TabIndex = 3;
            this.leftWall.Click += new System.EventHandler(this.leftWall_Click);
            // 
            // cb_wall
            // 
            this.cb_wall.AutoSize = true;
            this.cb_wall.Checked = true;
            this.cb_wall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_wall.Location = new System.Drawing.Point(10, 40);
            this.cb_wall.Name = "cb_wall";
            this.cb_wall.Size = new System.Drawing.Size(91, 16);
            this.cb_wall.TabIndex = 0;
            this.cb_wall.Text = "Show Wall :";
            this.cb_wall.UseVisualStyleBackColor = true;
            // 
            // cb_zeroPoint
            // 
            this.cb_zeroPoint.AutoSize = true;
            this.cb_zeroPoint.Checked = true;
            this.cb_zeroPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_zeroPoint.Location = new System.Drawing.Point(131, 56);
            this.cb_zeroPoint.Name = "cb_zeroPoint";
            this.cb_zeroPoint.Size = new System.Drawing.Size(118, 16);
            this.cb_zeroPoint.TabIndex = 12;
            this.cb_zeroPoint.Text = "Show Zero Point";
            this.cb_zeroPoint.UseVisualStyleBackColor = true;
            // 
            // cb_guide
            // 
            this.cb_guide.AutoSize = true;
            this.cb_guide.Checked = true;
            this.cb_guide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_guide.Location = new System.Drawing.Point(14, 57);
            this.cb_guide.Name = "cb_guide";
            this.cb_guide.Size = new System.Drawing.Size(97, 16);
            this.cb_guide.TabIndex = 11;
            this.cb_guide.Text = "Show Guide ";
            this.cb_guide.UseVisualStyleBackColor = true;
            // 
            // backGroundTop
            // 
            this.backGroundTop.BackColor = System.Drawing.Color.White;
            this.backGroundTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backGroundTop.Location = new System.Drawing.Point(142, 14);
            this.backGroundTop.Name = "backGroundTop";
            this.backGroundTop.Size = new System.Drawing.Size(90, 25);
            this.backGroundTop.TabIndex = 2;
            this.backGroundTop.Click += new System.EventHandler(this.backGround_Click);
            // 
            // backGroundBot
            // 
            this.backGroundBot.BackColor = System.Drawing.Color.PowderBlue;
            this.backGroundBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backGroundBot.Location = new System.Drawing.Point(255, 14);
            this.backGroundBot.Name = "backGroundBot";
            this.backGroundBot.Size = new System.Drawing.Size(90, 25);
            this.backGroundBot.TabIndex = 2;
            this.backGroundBot.Click += new System.EventHandler(this.backGround_Click);
            // 
            // lb_backGround
            // 
            this.lb_backGround.AutoSize = true;
            this.lb_backGround.Location = new System.Drawing.Point(9, 21);
            this.lb_backGround.Name = "lb_backGround";
            this.lb_backGround.Size = new System.Drawing.Size(116, 12);
            this.lb_backGround.TabIndex = 1;
            this.lb_backGround.Text = "BackGround Color :";
            // 
            // tabModel
            // 
            this.tabModel.Controls.Add(this.groupBox4);
            this.tabModel.Controls.Add(this.groupBox3);
            this.tabModel.Controls.Add(this.cbBoxDrawMethod);
            this.tabModel.Controls.Add(this.lb_method);
            this.tabModel.Location = new System.Drawing.Point(4, 22);
            this.tabModel.Name = "tabModel";
            this.tabModel.Padding = new System.Windows.Forms.Padding(3);
            this.tabModel.Size = new System.Drawing.Size(581, 376);
            this.tabModel.TabIndex = 1;
            this.tabModel.Text = "Model";
            this.tabModel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_edges);
            this.groupBox4.Controls.Add(this.EdgeColor);
            this.groupBox4.Controls.Add(this.SelFaceColor);
            this.groupBox4.Controls.Add(this.cb_faces);
            this.groupBox4.Controls.Add(this.FaceColor);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(554, 107);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Object";
            // 
            // cb_edges
            // 
            this.cb_edges.AutoSize = true;
            this.cb_edges.Location = new System.Drawing.Point(24, 71);
            this.cb_edges.Name = "cb_edges";
            this.cb_edges.Size = new System.Drawing.Size(104, 16);
            this.cb_edges.TabIndex = 4;
            this.cb_edges.Text = "Show Edges :";
            this.cb_edges.UseVisualStyleBackColor = true;
            // 
            // EdgeColor
            // 
            this.EdgeColor.BackColor = System.Drawing.Color.Silver;
            this.EdgeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EdgeColor.Location = new System.Drawing.Point(131, 65);
            this.EdgeColor.Name = "EdgeColor";
            this.EdgeColor.Size = new System.Drawing.Size(90, 25);
            this.EdgeColor.TabIndex = 3;
            this.EdgeColor.Click += new System.EventHandler(this.EdgeColor_Click);
            // 
            // cb_faces
            // 
            this.cb_faces.AutoSize = true;
            this.cb_faces.Checked = true;
            this.cb_faces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_faces.Location = new System.Drawing.Point(24, 26);
            this.cb_faces.Name = "cb_faces";
            this.cb_faces.Size = new System.Drawing.Size(103, 16);
            this.cb_faces.TabIndex = 2;
            this.cb_faces.Text = "Show Faces :";
            this.cb_faces.UseVisualStyleBackColor = true;
            // 
            // FaceColor
            // 
            this.FaceColor.BackColor = System.Drawing.Color.Gold;
            this.FaceColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FaceColor.Location = new System.Drawing.Point(131, 20);
            this.FaceColor.Name = "FaceColor";
            this.FaceColor.Size = new System.Drawing.Size(90, 25);
            this.FaceColor.TabIndex = 1;
            this.FaceColor.Click += new System.EventHandler(this.FaceColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_heightAuto);
            this.groupBox3.Controls.Add(this.cb_thicknessAuto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericHeight);
            this.groupBox3.Controls.Add(this.numericThickness);
            this.groupBox3.Controls.Add(this.lb_height);
            this.groupBox3.Controls.Add(this.lb_thickness);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.travelColor);
            this.groupBox3.Controls.Add(this.pathColor);
            this.groupBox3.Controls.Add(this.cb_travel);
            this.groupBox3.Controls.Add(this.cb_segment);
            this.groupBox3.Controls.Add(this.cbBoxDrawQuality);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(554, 174);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // cb_heightAuto
            // 
            this.cb_heightAuto.AutoSize = true;
            this.cb_heightAuto.Location = new System.Drawing.Point(303, 142);
            this.cb_heightAuto.Name = "cb_heightAuto";
            this.cb_heightAuto.Size = new System.Drawing.Size(49, 16);
            this.cb_heightAuto.TabIndex = 10;
            this.cb_heightAuto.Text = "Auto";
            this.cb_heightAuto.UseVisualStyleBackColor = true;
            // 
            // cb_thicknessAuto
            // 
            this.cb_thicknessAuto.AutoSize = true;
            this.cb_thicknessAuto.Location = new System.Drawing.Point(303, 116);
            this.cb_thicknessAuto.Name = "cb_thicknessAuto";
            this.cb_thicknessAuto.Size = new System.Drawing.Size(49, 16);
            this.cb_thicknessAuto.TabIndex = 10;
            this.cb_thicknessAuto.Text = "Auto";
            this.cb_thicknessAuto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "[mm]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "[mm]";
            // 
            // numericHeight
            // 
            this.numericHeight.DecimalPlaces = 2;
            this.numericHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericHeight.Location = new System.Drawing.Point(123, 142);
            this.numericHeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 21);
            this.numericHeight.TabIndex = 5;
            this.numericHeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numericThickness
            // 
            this.numericThickness.DecimalPlaces = 2;
            this.numericThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericThickness.Location = new System.Drawing.Point(123, 112);
            this.numericThickness.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericThickness.Name = "numericThickness";
            this.numericThickness.Size = new System.Drawing.Size(120, 21);
            this.numericThickness.TabIndex = 5;
            this.numericThickness.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // lb_height
            // 
            this.lb_height.AutoSize = true;
            this.lb_height.Location = new System.Drawing.Point(24, 146);
            this.lb_height.Name = "lb_height";
            this.lb_height.Size = new System.Drawing.Size(84, 12);
            this.lb_height.TabIndex = 4;
            this.lb_height.Text = "Layer Height :";
            // 
            // lb_thickness
            // 
            this.lb_thickness.AutoSize = true;
            this.lb_thickness.Location = new System.Drawing.Point(24, 115);
            this.lb_thickness.Name = "lb_thickness";
            this.lb_thickness.Size = new System.Drawing.Size(72, 12);
            this.lb_thickness.TabIndex = 4;
            this.lb_thickness.Text = "Thickness :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "3D Quality :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "3D Quality :";
            // 
            // travelColor
            // 
            this.travelColor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.travelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.travelColor.Location = new System.Drawing.Point(395, 61);
            this.travelColor.Name = "travelColor";
            this.travelColor.Size = new System.Drawing.Size(90, 25);
            this.travelColor.TabIndex = 2;
            this.travelColor.Click += new System.EventHandler(this.travelColor_Click);
            // 
            // pathColor
            // 
            this.pathColor.BackColor = System.Drawing.Color.DarkGray;
            this.pathColor.Controls.Add(this.panel3);
            this.pathColor.Location = new System.Drawing.Point(122, 61);
            this.pathColor.Name = "pathColor";
            this.pathColor.Size = new System.Drawing.Size(90, 25);
            this.pathColor.TabIndex = 2;
            this.pathColor.Click += new System.EventHandler(this.pathColor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 25);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.pathColor_Click);
            // 
            // cb_travel
            // 
            this.cb_travel.AutoSize = true;
            this.cb_travel.Checked = true;
            this.cb_travel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_travel.Location = new System.Drawing.Point(257, 68);
            this.cb_travel.Name = "cb_travel";
            this.cb_travel.Size = new System.Drawing.Size(132, 16);
            this.cb_travel.TabIndex = 2;
            this.cb_travel.Text = "Show Travel Path :";
            this.cb_travel.UseVisualStyleBackColor = true;
            // 
            // cb_segment
            // 
            this.cb_segment.AutoSize = true;
            this.cb_segment.Checked = true;
            this.cb_segment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_segment.Location = new System.Drawing.Point(23, 68);
            this.cb_segment.Name = "cb_segment";
            this.cb_segment.Size = new System.Drawing.Size(93, 16);
            this.cb_segment.TabIndex = 2;
            this.cb_segment.Text = "Show Path :";
            this.cb_segment.UseVisualStyleBackColor = true;
            // 
            // cbBoxDrawQuality
            // 
            this.cbBoxDrawQuality.FormattingEnabled = true;
            this.cbBoxDrawQuality.Items.AddRange(new object[] {
            "Low",
            "Middle",
            "High",
            "Great High"});
            this.cbBoxDrawQuality.Location = new System.Drawing.Point(99, 29);
            this.cbBoxDrawQuality.Name = "cbBoxDrawQuality";
            this.cbBoxDrawQuality.Size = new System.Drawing.Size(250, 20);
            this.cbBoxDrawQuality.TabIndex = 1;
            // 
            // cbBoxDrawMethod
            // 
            this.cbBoxDrawMethod.FormattingEnabled = true;
            this.cbBoxDrawMethod.Items.AddRange(new object[] {
            "Automatic",
            "VBOs( Need Renderer and OpenGL v1.5 Higher )",
            "Arrays ( Need OpenGL v1.1 Higher )",
            "No Method ( Need Nothing But Slow )"});
            this.cbBoxDrawMethod.Location = new System.Drawing.Point(95, 18);
            this.cbBoxDrawMethod.Name = "cbBoxDrawMethod";
            this.cbBoxDrawMethod.Size = new System.Drawing.Size(250, 20);
            this.cbBoxDrawMethod.TabIndex = 1;
            // 
            // lb_method
            // 
            this.lb_method.AutoSize = true;
            this.lb_method.Location = new System.Drawing.Point(19, 22);
            this.lb_method.Name = "lb_method";
            this.lb_method.Size = new System.Drawing.Size(73, 12);
            this.lb_method.TabIndex = 0;
            this.lb_method.Text = "3D Method :";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(507, 437);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // SelFaceColor
            // 
            this.SelFaceColor.BackColor = System.Drawing.Color.Green;
            this.SelFaceColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelFaceColor.Location = new System.Drawing.Point(370, 20);
            this.SelFaceColor.Name = "SelFaceColor";
            this.SelFaceColor.Size = new System.Drawing.Size(90, 25);
            this.SelFaceColor.TabIndex = 1;
            this.SelFaceColor.Click += new System.EventHandler(this.SelFaceColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selected Object :";
            // 
            // GraphicConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(625, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graphic Setting";
            this.TopMost = true;
            this.tabControl.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlpha)).EndInit();
            this.tabModel.ResumeLayout(false);
            this.tabModel.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThickness)).EndInit();
            this.pathColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabModel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lb_backGround;
        private System.Windows.Forms.Label lb_rightWall;
        private System.Windows.Forms.Label lb_bottomWall;
        private System.Windows.Forms.Label lb_backWall;
        private System.Windows.Forms.Label lb_leftWall;
        public System.Windows.Forms.Panel backGroundBot;
        public System.Windows.Forms.Panel rightWall;
        public System.Windows.Forms.Panel bottomWall;
        public System.Windows.Forms.Panel backWall;
        public System.Windows.Forms.Panel leftWall;
        public System.Windows.Forms.CheckBox cb_wall;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericGrid;
        public System.Windows.Forms.CheckBox cb_gridAuto;
        public System.Windows.Forms.CheckBox cb_grid;
        public System.Windows.Forms.NumericUpDown numericAlpha;
        public System.Windows.Forms.CheckBox cb_alpha;
        public System.Windows.Forms.CheckBox cb_gridValue;
        public System.Windows.Forms.CheckBox cb_guide;
        public System.Windows.Forms.CheckBox cb_zeroPoint;
        private System.Windows.Forms.Label lb_gridColor;
        public System.Windows.Forms.Panel grid;
        public System.Windows.Forms.CheckBox cb_gridYZ;
        public System.Windows.Forms.CheckBox cb_gridXZ;
        public System.Windows.Forms.CheckBox cb_gridXY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_method;
        public System.Windows.Forms.ComboBox cbBoxDrawMethod;
        public System.Windows.Forms.Panel travelColor;
        public System.Windows.Forms.Panel pathColor;
        public System.Windows.Forms.CheckBox cb_travel;
        public System.Windows.Forms.CheckBox cb_segment;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbBoxDrawQuality;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel EdgeColor;
        public System.Windows.Forms.Panel FaceColor;
        public System.Windows.Forms.CheckBox cb_edges;
        public System.Windows.Forms.CheckBox cb_faces;
        private System.Windows.Forms.Label lb_height;
        private System.Windows.Forms.Label lb_thickness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown numericHeight;
        public System.Windows.Forms.NumericUpDown numericThickness;
        private System.Windows.Forms.CheckBox cb_heightAuto;
        private System.Windows.Forms.CheckBox cb_thicknessAuto;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.CheckBox cb_light4;
        public System.Windows.Forms.CheckBox cb_light3;
        public System.Windows.Forms.CheckBox cb_light2;
        public System.Windows.Forms.CheckBox cb_light1;
        public System.Windows.Forms.CheckBox cb_ortho;
        public System.Windows.Forms.CheckBox cb_gradient;
        public System.Windows.Forms.Panel backGroundTop;
        public System.Windows.Forms.Panel SelFaceColor;
        private System.Windows.Forms.Label label4;
    }
}