using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;
using OpenTK;
using System.Diagnostics;
using TSC.Class;

namespace TSC.View
{
    public partial class GraphicControl : UserControl
    {
        public GraphicView view = null;

        bool loaded = false;

        int xDown, yDown;
        int xPos, yPos;
        float speedX, speedY;
        float startRotY = 0, startRotX = 0;
        float lastX, lastY;
        Vector3 startCenter;
        Vector3 startViewPoint;
        int mode = 0;
        int GridWidth;
        Stopwatch fpsTimer;

        GraphicModel selModel = null;
        int selAxis = -1;
        bool anySelect = false;
        Vector3 startPoint;

        public GraphicControl()
        {
            InitializeComponent();
            gl.MouseWheel += gl_MouseWheel;
            fpsTimer = new Stopwatch();
        }

        public void SetView(GraphicView view)
        {
            this.view = view;
        }

        private void gl_Load(object sender, EventArgs e)
        {
            string sv = GL.GetString(StringName.Version).Trim();
            int p = sv.IndexOf(" ");

            if (p > 0) sv = sv.Substring(0, p);
            p = sv.IndexOf('.');
            if (p > 0)
            {
                p = sv.IndexOf('.', p + 1);
                if (p > 0)
                    sv = sv.Substring(0, p);
            }
            try
            {
                Main.graphicConfig.openGLVer = float.Parse(sv);
            }
            catch
            {
                Main.graphicConfig.openGLVer = 1.1f;
            }
            string extensions = GL.GetString(StringName.Extensions);
            foreach (string s in extensions.Split(' '))
            {
                if (s.Equals("GL_ARB_vertex_buffer_object")/* && Main.threeDSettings.openGLVersion>1.49*/)
                {
                    Main.graphicConfig.renderSupport = true;
                }
            }

            loaded = true;
            SetupViewport();
        }

        private void gl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                view.zoom *= 1f - e.Delta / 1200f;
                if (view.zoom < 0.01) view.zoom = 0.01f;
                if (view.zoom > 5.9) view.zoom = 5.9f;

                gl.Invalidate();
            }
        }

        bool push = false;
        //int startX, startY, endX, endY;

        private void gl_MouseDown(object sender, MouseEventArgs e)
        {
            // pick and Move
            if (e.Button == MouseButtons.Left) {
                startPoint = GetPickPoint(e.X, e.Y);
                SelectObject(e.X, e.Y);
                if (selModel == null) {
                    anySelect = false;
                    gl.Invalidate();
                    return;
                }

                selModel.Selected = true;
                anySelect = true;
                gl.Invalidate();
            }


            push = true;
            //startX = e.X;
            //startY = e.Y;



            lastX = xDown = e.X;
            lastY = yDown = e.Y;
            startRotX = view.rotX;
            startRotY = view.rotY;
            startCenter = view.Center;
            startViewPoint = view.viewPoint;

        }

        private void gl_MouseUp(object sender, MouseEventArgs e)
        {
            speedX = speedY = 0;
            push = false;
        }

        private void gl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None) {
                speedX = speedY = 0;
                return;
            }

            xPos = e.X;
            yPos = e.Y;

            float d = Math.Min(gl.Width, gl.Height) / 3;
            speedX = Math.Max(-1, Math.Min(1, (xPos - xDown) / d));
            speedY = Math.Max(-1, Math.Min(1, (yPos - yDown) / d));

        }

        private void SetupViewport()
        {
            int w = gl.Width;
            int h = gl.Height;

            float dx = view.Center.X - view.viewPoint.X;
            float dy = view.Center.Y - view.viewPoint.Y;
            float dz = view.Center.Z - view.viewPoint.Z;

            float dist = (float)Math.Sqrt(dx * dx + dy * dy + dz * dz);


            GL.Viewport(0, 0, w, h);

            GL.LoadIdentity();

            GL.MatrixMode(MatrixMode.Projection);


            view.aspectRatio = Width / (float)Height;
            view.nearDist = Math.Max(10, dist - 2f * (Main.basicConfig.printSizeX / 2));
            view.farDist = dist + 2f * (Main.basicConfig.printSizeY / 2);
            view.nearHeight = 2.0f * (float)Math.Tan(view.zoom * 15f * Math.PI / 180f) * view.nearDist;

            if (Main.graphicConfig.cb_ortho.Checked)
            {
                view.persp = Matrix4.CreateOrthographic(1.9f * view.nearHeight * view.aspectRatio, 1.9f * view.nearHeight, view.nearDist, view.farDist);
            }
            else
            {
                view.persp = Matrix4.CreatePerspectiveFieldOfView((float)(view.zoom * 30f * Math.PI / 180f), view.aspectRatio, view.nearDist, view.farDist);
            }
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref view.persp);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            Vector3 Veye = new Vector3(view.viewPoint);
            Vector3 Vtarget = new Vector3(view.Center);
            Vector3 Vup = new Vector3(0, 1, 0);

            view.lookAt = Matrix4.LookAt(Veye + Vtarget, Vtarget, Vup);

            GL.LoadMatrix(ref view.lookAt);

            //GL.Rotate(view.rotX, 1, 0, 0);
            //GL.Rotate(view.rotY, 0, 0, 1);
        }


        private void DrawGrid()
        {
            GL.Color3(Main.graphicConfig.grid.BackColor);

            GL.Begin(PrimitiveType.Lines);

            GL.Translate(0, 0, -0.1);

            int x, y, z;

            GridWidth = (int)Main.graphicConfig.numericGrid.Value;

            if (Main.graphicConfig.cb_gridAuto.Checked)
            {
                if (view.zoom * 100 > 70)
                    GridWidth = 100;
                else if (view.zoom * 100 > 50)
                    GridWidth = 50;
                else if (view.zoom * 100 > 30)
                    GridWidth = 10;
                else if (view.zoom * 100 > 10)
                    GridWidth = 5;
                else
                    GridWidth = 1;
            }

            if (Main.graphicConfig.cb_gridValue.Checked)
            {
                lb_GridSize.Text = GridWidth.ToString();
            }

            if (Main.graphicConfig.cb_gridXY.Checked)
            {
                for (int i = 0; i <= Main.basicConfig.printSizeX; i++)
                {
                    x = i * GridWidth;
                    if (x > Main.basicConfig.printSizeX) break;
                    GL.Vertex3(x - (Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), 0);
                    GL.Vertex3(x - (Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
                }
                for (int i = 0; i <= Main.basicConfig.printSizeY; i++)
                {
                    y = i * GridWidth;
                    if (y > Main.basicConfig.printSizeY) break;
                    GL.Vertex3(-(Main.basicConfig.printSizeX / 2), y - (Main.basicConfig.printSizeY / 2), 0);
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), y - (Main.basicConfig.printSizeY / 2), 0);
                }
            }

            if (Main.graphicConfig.cb_gridXZ.Checked)
            {
                for (int i = 0; i <= Main.basicConfig.printSizeZ; i++)
                {
                    z = i * GridWidth;
                    if (z > Main.basicConfig.printSizeZ) break;
                    GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), z);
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), z);
                }
                for (int i = 0; i <= Main.basicConfig.printSizeX; i++)
                {
                    x = i * GridWidth;
                    if (x > Main.basicConfig.printSizeX) break;
                    GL.Vertex3(x - (Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
                    GL.Vertex3(x - (Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
                }
            }

            if(Main.graphicConfig.cb_gridYZ.Checked)
            {
                for (int i = 0; i <= Main.basicConfig.printSizeZ; i++)
                {
                    z = i * GridWidth;
                    if (z > Main.basicConfig.printSizeZ) break;
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), z);
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), z);
                }
                for (int i = 0; i <= Main.basicConfig.printSizeY; i++)
                {
                    y = i * GridWidth;
                    if (y > Main.basicConfig.printSizeY) break;
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), y - (Main.basicConfig.printSizeY / 2), 0);
                    GL.Vertex3((Main.basicConfig.printSizeX / 2), y - (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
                }
            }

            GL.End();
            
        }


        private void DrawWall()
        {
            GL.Enable(EnableCap.Blend);
            GL.DepthMask(false);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.Begin(PrimitiveType.Quads);

            OpenTK.Graphics.Color4 colorLeft = Main.graphicConfig.leftWall.BackColor;
            OpenTK.Graphics.Color4 colorBack = Main.graphicConfig.backWall.BackColor;
            OpenTK.Graphics.Color4 colorBottom = Main.graphicConfig.bottomWall.BackColor;
            OpenTK.Graphics.Color4 colorRight = Main.graphicConfig.rightWall.BackColor;

            if (Main.graphicConfig.cb_alpha.Checked)
            {
                colorRight.A = colorBottom.A = colorBack.A = colorLeft.A = (float)Main.graphicConfig.numericAlpha.Value / 255.0f;
            }
            GL.Color4(colorLeft);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);


            GL.Color4(colorBack);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);


            GL.Color4(colorBottom);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3(-(Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);


            GL.Color4(colorRight);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), Main.basicConfig.printSizeZ);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), (Main.basicConfig.printSizeY / 2), 0);
            GL.Vertex3((Main.basicConfig.printSizeX / 2), -(Main.basicConfig.printSizeY / 2), 0);

            GL.End();
            GL.DepthMask(true);
            GL.Disable(EnableCap.Blend);
        }

        private void DrawGuide()
        {
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.DepthTest);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 presp = Matrix4.CreatePerspectiveFieldOfView(60f * (float)Math.PI / 180f, 1f, 50f, 150f);
            GL.LoadMatrix(ref presp);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Matrix4 lookup = Matrix4.LookAt(0, 0, 100, 0, 0, 0, 0, 1, 0);
            GL.LoadMatrix(ref lookup);
            GL.Viewport(5, 5, 100, 100);

            GL.Rotate(view.rotX, 1, 0, 0);
            GL.Rotate(view.rotY, 0, 0, 1);


            float[] viewM = new float[16];
            GL.GetFloat(GetPName.ModelviewMatrix, viewM);

            float length = 8f;

            Vector3 rightV = new Vector3(viewM[0], viewM[4], viewM[8]);
            Vector3 upV = new Vector3(viewM[1], viewM[5], viewM[9]);
            Vector3 Pos;


            GL.LineWidth(2.9f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(30, 0, 0);

            Pos = new Vector3(40f, 0f, 0f);


            GL.Vertex3(Pos - (rightV * 2 / 3 + upV) * length);
            GL.Vertex3(Pos + (rightV * 2 / 3 + upV) * length);
            GL.Vertex3(Pos - (rightV * 2 / 3 - upV) * length);
            GL.Vertex3(Pos + (rightV * 2 / 3 - upV) * length);


            GL.End();
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex3(25, 7, 0);
            //GL.Vertex3(25, -7, 0);
            //GL.Vertex3(35, 0, 0);

            //GL.Vertex3(25, 0, 7);
            //GL.Vertex3(25, 0, -7);
            //GL.Vertex3(35, 0, 0);
            //GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 30, 0);

            Pos = new Vector3(0f, 40f, 0f);

            GL.Vertex3(Pos);
            GL.Vertex3(Pos + (rightV * 2 / 3f + upV) * length);
            GL.Vertex3(Pos);
            GL.Vertex3(Pos + (upV - rightV * 2 / 3f) * length);
            GL.Vertex3(Pos);
            GL.Vertex3(Pos - upV * length);



            GL.End();
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex3(7, 25, 0);
            //GL.Vertex3(-7, 25, 0);
            //GL.Vertex3(0, 30, 0);

            //GL.Vertex3(0, 25, 7);
            //GL.Vertex3(0, 25, -7);
            //GL.Vertex3(0, 30, 0);
            //GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, 30);

            Pos = new Vector3(0f, 0f, 40f);

            GL.Vertex3(Pos + (upV - rightV) * length * 2 / 3f);
            GL.Vertex3(Pos + (upV + rightV) * length * 2 / 3f);
            GL.Vertex3(Pos + (upV + rightV) * length * 2 / 3f);
            GL.Vertex3(Pos - (upV + rightV) * length * 2 / 3f);
            GL.Vertex3(Pos - (upV + rightV) * length * 2 / 3f);
            GL.Vertex3(Pos + (rightV - upV) * length * 2 / 3f);



            GL.End();
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Vertex3(0, 7, 25);
            //GL.Vertex3(0, -7, 25);
            //GL.Vertex3(0, 0, 30);
            //GL.Vertex3(7, 0, 25);
            //GL.Vertex3(-7, 0, 25);
            //GL.Vertex3(0, 0, 30);
            //GL.End();
            GL.LineWidth(1);

        }

        private void initGL()
        {
            float[] ambientLight = { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] diffuseLight = { 0.5f, 0.5f, 0.5f, 1.0f };
            float[] lightPos1 = { -1.0f, -1.0f, 2.0f, 1.0f };
            float[] lightPos2 = { 1.0f, 2.0f, 3.0f, 1.0f };
            float[] lightPos3 = { 1.7f, -1.0f, 2.0f, 1.0f };
            float[] lightPos4 = { 1.7f, -1.0f, -2.5f, 1.0f };
            float[] specref = { 1.0f, 1.0f, 1.0f, 1.0f };

            GL.ShadeModel(ShadingModel.Smooth);

            GL.ClearColor(Main.graphicConfig.backGroundBot.BackColor);
            GL.Clear(ClearBufferMask.ColorBufferBit |
                       ClearBufferMask.DepthBufferBit);

            if (Main.graphicConfig.cb_gradient.Checked)
            {
                GL.Viewport(0, 0, gl.Width, gl.Height);
                GL.MatrixMode(MatrixMode.Projection);
                GL.LoadIdentity();
                GL.MatrixMode(MatrixMode.Modelview);
                GL.LoadIdentity();
                GL.Disable(EnableCap.DepthTest);
                GL.Begin(PrimitiveType.Quads);
                GL.Color4(Main.graphicConfig.backGroundBot.BackColor);
                GL.Vertex2(-1.0, -1.0);
                GL.Vertex2(1.0, -1.0);
                GL.Color4(Main.graphicConfig.backGroundTop.BackColor);
                GL.Vertex2(1.0, 1.0);
                GL.Vertex2(-1.0, 1.0);
                GL.End();
            }
            

            GL.ClearDepth(1.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            GL.FrontFace(FrontFaceDirection.Ccw);

            GL.Enable(EnableCap.Lighting);

            GL.Light(LightName.Light0, LightParameter.Ambient, ambientLight);
            GL.Light(LightName.Light0, LightParameter.Diffuse, diffuseLight);
            GL.Light(LightName.Light0, LightParameter.Specular, specref);
            GL.Enable(EnableCap.Light0);

            if (Main.graphicConfig.cb_light1.Checked)
            {
                GL.Light(LightName.Light1, LightParameter.Ambient, ambientLight);
                GL.Light(LightName.Light1, LightParameter.Diffuse, diffuseLight);
                GL.Light(LightName.Light1, LightParameter.Position, lightPos1);
                GL.Light(LightName.Light1, LightParameter.Specular, specref);
                GL.Enable(EnableCap.Light1);
            }
            else GL.Disable(EnableCap.Light1);

            if (Main.graphicConfig.cb_light2.Checked)
            {
                GL.Light(LightName.Light2, LightParameter.Ambient, ambientLight);
                GL.Light(LightName.Light2, LightParameter.Diffuse, diffuseLight);
                GL.Light(LightName.Light2, LightParameter.Position, lightPos2);
                GL.Light(LightName.Light2, LightParameter.Specular, specref);
                GL.Enable(EnableCap.Light2);
            }
            else GL.Disable(EnableCap.Light2);

            if (Main.graphicConfig.cb_light3.Checked)
            {
                GL.Light(LightName.Light3, LightParameter.Ambient, ambientLight);
                GL.Light(LightName.Light3, LightParameter.Diffuse, diffuseLight);
                GL.Light(LightName.Light3, LightParameter.Position, lightPos3);
                GL.Light(LightName.Light3, LightParameter.Specular, specref);
                GL.Enable(EnableCap.Light3);
            }
            else GL.Disable(EnableCap.Light3);

            if (Main.graphicConfig.cb_light4.Checked)
            {
                GL.Light(LightName.Light4, LightParameter.Ambient, ambientLight);
                GL.Light(LightName.Light4, LightParameter.Diffuse, diffuseLight);
                GL.Light(LightName.Light4, LightParameter.Position, lightPos4);
                GL.Light(LightName.Light4, LightParameter.Specular, specref);
                GL.Enable(EnableCap.Light4);
            }
            else GL.Disable(EnableCap.Light4);

            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, specref);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 10);

            GL.DepthFunc(DepthFunction.Lequal);
            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);

        }

        private void gl_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) return;

            switch(Main.graphicConfig.cbBoxDrawMethod.SelectedIndex)
            {
                case 0:
                    if (Main.graphicConfig.renderSupport && Main.graphicConfig.openGLVer >= 1.499)
                        Main.graphicConfig.drawMethod = 2;
                    else if (Main.graphicConfig.openGLVer >= 1.099)
                        Main.graphicConfig.drawMethod = 1;
                    else
                        Main.graphicConfig.drawMethod = 0;
                    break;
                case 1:
                    Main.graphicConfig.drawMethod = 2;
                    break;
                case 2:
                    Main.graphicConfig.drawMethod = 1;
                    break;
                case 3:
                    Main.graphicConfig.drawMethod = 0;
                    break;
            }

            fpsTimer.Reset();
            fpsTimer.Start();

            gl.MakeCurrent();

            
            initGL();
            SetupViewport();

            GL.Rotate(view.rotX, 1, 0, 0);
            GL.Rotate(view.rotY, 0, 0, 1);
            


           
            //GL.LoadIdentity();

            GL.Translate(0, 0, 0.01);

            foreach (GraphicModel model in view.models)
            {
                GL.PushMatrix();
                GL.Translate(model.Position.x, model.Position.y, model.Position.z);
                GL.Rotate(model.Rotation.z, Vector3.UnitZ);
                GL.Rotate(model.Rotation.y, Vector3.UnitY);
                GL.Rotate(model.Rotation.x, Vector3.UnitX);
                GL.Scale(model.Scale.x, model.Scale.y, model.Scale.z);
                model.Paint();
                GL.PopMatrix();
            }

            GL.Disable(EnableCap.Lighting);

            if (Main.graphicConfig.cb_zeroPoint.Checked)
            {
                GL.PushMatrix();
                DrawZeroPoint();
                GL.PopMatrix();
            }

            GL.Translate(0, 0, -0.01);

            if (Main.graphicConfig.cb_grid.Checked)
            {
                DrawGrid();
            }
            if (Main.graphicConfig.cb_wall.Checked)
            {
                DrawWall();
            }
            if (Main.graphicConfig.cb_guide.Checked)
            {
                DrawGuide();
            }

            gl.SwapBuffers();
            fpsTimer.Stop();
            double framerate = 1.0 / fpsTimer.Elapsed.TotalSeconds;
            Main.main.lb_fps.Text = framerate.ToString("0") + " FPS";



        }

        //private void PrintString()
        //{
        //    Font font = new System.Drawing.Font(FontFamily.GenericSansSerif, 16);
        //    QFont qFont = new QFont(font);
        //    QFont.Begin();
        //    qFont.Print("HELLO WORLD!!");
        //    QFont.End();
        //    GL.Disable(EnableCap.Blend);
        //    GL.Disable(EnableCap.Texture2D);
            
        //}

        private void DrawZeroPoint()
        {
            //use bill board technique
            GL.Color3(Color.Red);
            float[] viewM = new float[16];
            
            GL.GetFloat(GetPName.ModelviewMatrix, viewM);
            float length = 6.0f * view.zoom;

            Vector3 rightV = new Vector3(viewM[0], viewM[4], viewM[8]);
            Vector3 upV = new Vector3(viewM[1], viewM[5], viewM[9]);

            Vector3 Pos = new Vector3(0 - (Main.basicConfig.printSizeX / 2), 0 - (Main.basicConfig.printSizeY / 2), 0);
            GL.Begin(PrimitiveType.Polygon);

            GL.Vertex3(Pos + rightV * length * (float)6 / 7);
            GL.Vertex3(Pos + (rightV + upV) * length * (float)7 / 11);
            GL.Vertex3(Pos + upV * length * (float)6 / 7);
            GL.Vertex3(Pos + (upV - rightV) * length * (float)7 / 11);
            GL.Vertex3(Pos - rightV * length * (float)6 / 7);
            GL.Vertex3(Pos - (rightV + upV) * length * (float)7 / 11);
            GL.Vertex3(Pos - upV * length * (float)6 / 7);
            GL.Vertex3(Pos + (rightV - upV) * length * (float)7 / 11);

            GL.End();
        }

        public void Application_Idle()
        {
            //if (nc.ncMove)
            //{
            //    gl.Invalidate();
            //    nc.ncMove = false;
            //    return;
            //}
            if (!loaded || ((speedX == 0 && speedY == 0))) return;

            int emode = mode;
            if (Control.MouseButtons == MouseButtons.Right) emode = 1;
            else if (Control.MouseButtons == MouseButtons.Left) emode = 2;

            if (!push) return;

            if (emode == 0)
            {
                speedX = (float)(xPos - xDown) / gl.Width;
                speedY = (float)(yPos - yDown) / gl.Height;
                Main.main.lb_diff.Text = "x : " + speedX.ToString() + " y : " + speedY.ToString();
                view.Center.X = startCenter.X - speedX * 150 * view.zoom;
                view.Center.Y = startCenter.Y + speedY * 150 * view.zoom;
                gl.Invalidate();
            }
            else if (emode == 1)
            {
                float d = Math.Min(gl.Width, gl.Height) / 3;
                speedX = (xPos - xDown) / d;
                speedY = -1 * (yPos - yDown) / d;
                view.rotY = startRotY + speedX * 20;
                view.rotX = startRotX - speedY * 20;
                gl.Invalidate();
            }
            else if (emode == 2) 
            {
                if (selAxis != -1) {

                    Vector3 currentPos = GetPickPoint(xPos, yPos);
                    Vector3 diff = currentPos - startPoint;
                    startPoint = currentPos;

                    Main.main.lb_diff.Text = diff.X + ", " + diff.Y + ", " + diff.Z;

                    switch (selAxis) {
                        case 0:
                            selModel.Position.x += diff.X;
                            break;
                        case 1:
                            selModel.Position.y += diff.Y;
                            break;
                        case 2:
                            selModel.Position.z += diff.Z;
                            break;
                    }
                    gl.Invalidate();
                }
            }
        }

        public void UpdateGLView()
        {
            gl.Invalidate();
        }

        private void toolSB_front_Click(object sender, EventArgs e)
        {
            view.rotX = -90;
            view.rotY = 0;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_back_Click(object sender, EventArgs e)
        {
            view.rotX = -90;
            view.rotY = 180;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_left_Click(object sender, EventArgs e)
        {
            view.rotX = -90;
            view.rotY = 90;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_right_Click(object sender, EventArgs e)
        {
            view.rotX = -90;
            view.rotY = -90;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_top_Click(object sender, EventArgs e)
        {
            view.rotX = 0;
            view.rotY = 0;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_bottom_Click(object sender, EventArgs e)
        {
            view.rotX = -180;
            view.rotY = 0;
            view.Center = new Vector3(0, 0, 0);
            gl.Invalidate();
        }

        private void toolSB_reset_Click(object sender, EventArgs e)
        {
            view.rotX = -45;
            view.rotY = 0;
            view.Center = new Vector3(0, 0, 0);
            view.zoom = 1.0f;
            gl.Invalidate();
        }

        private void SelectObject(int x, int y)
        {
            int[] selectBuff = new int[64];
            int hits;
            int[] viewport = new int[4];
            GL.SelectBuffer(64, selectBuff);            
            GL.RenderMode(RenderingMode.Select);
            SetupViewport();

            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();

            GL.GetInteger(GetPName.Viewport, viewport);

            float precise = anySelect ? 8 : 0.1f;

            Matrix4 m = GluPickMatrix(x, viewport[3] - y, precise, precise, viewport);

            GL.MultMatrix(ref m);

            GL.MultMatrix(ref view.persp);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref view.lookAt);
            


            GL.InitNames();
            int pos = 0;

            GL.Rotate(view.rotX, 1, 0, 0);
            GL.Rotate(view.rotY, 0, 0, 1);

            GL.Translate(0, 0, 0.01);

            if (anySelect) {

                Vector3 Mcenter = selModel.getCenter();
                Vector3 MoveGuideX = new Vector3(Mcenter.X + (selModel.xMax - selModel.xMin) / 2, Mcenter.Y, Mcenter.Z);
                Vector3 MoveGuideY = new Vector3(Mcenter.X, Mcenter.Y + (selModel.yMax - selModel.yMin) / 2, Mcenter.Z);
                Vector3 MoveGuideZ = new Vector3(Mcenter.X, Mcenter.Y, Mcenter.Z + (selModel.zMax + selModel.zMin) / 2);


                GL.Translate(selModel.Position.x, selModel.Position.y, selModel.Position.z);
                GL.Rotate(selModel.Rotation.z, Vector3.UnitZ);
                GL.Rotate(selModel.Rotation.y, Vector3.UnitY);
                GL.Rotate(selModel.Rotation.x, Vector3.UnitX);
                GL.Scale(selModel.Scale.x, selModel.Scale.y, selModel.Scale.z);

                GL.Color3(Color.Red);
                GL.PushName(pos++);
                GL.PushMatrix();
                GL.Begin(PrimitiveType.Lines);
                GL.Vertex3(MoveGuideX);
                MoveGuideX.X += 20;
                GL.Vertex3(MoveGuideX);
                GL.End();
                GL.PopMatrix();
                GL.PopName();

                GL.Color3(Color.Green);
                GL.PushName(pos++);
                GL.PushMatrix();
                GL.Begin(PrimitiveType.Lines);
                GL.Vertex3(MoveGuideY);
                MoveGuideY.Y += 20;
                GL.Vertex3(MoveGuideY);
                GL.End();
                GL.PopMatrix();
                GL.PopName();

                GL.Color3(Color.Blue);
                GL.PushName(pos++);
                GL.PushMatrix();
                GL.Begin(PrimitiveType.Lines);
                GL.Vertex3(MoveGuideZ);
                MoveGuideZ.Z += 20;
                GL.Vertex3(MoveGuideZ);
                GL.End();
                GL.PopMatrix();
                GL.PopName();


                GL.End();

            }
            else {

                foreach (GraphicModel model in view.models) {
                    GL.PushName(pos++);
                    GL.PushMatrix();
                    GL.Translate(model.Position.x, model.Position.y, model.Position.z);
                    GL.Rotate(model.Rotation.z, Vector3.UnitZ);
                    GL.Rotate(model.Rotation.y, Vector3.UnitY);
                    GL.Rotate(model.Rotation.x, Vector3.UnitX);
                    GL.Scale(model.Scale.x, model.Scale.y, model.Scale.z);
                    model.Paint();
                    model.Selected = false;
                    GL.PopMatrix();
                    GL.PopName();
                }

            }

            
            hits = GL.RenderMode(RenderingMode.Render);

            Main.main.Hitlable.Text = hits.ToString();

            if (hits > 0) {
                if (anySelect)
                    selAxis = ProcessSelect(hits, selectBuff);
                else
                    selModel = view.models.ElementAt(ProcessSelect(hits, selectBuff));
                    
            }
            else {
                if (selModel != null) {
                    selModel.Selected = false;
                    selModel = null;
                }
                selAxis = -1;
            }

            GL.MatrixMode(MatrixMode.Projection);
            GL.PopMatrix();
            GL.MatrixMode(MatrixMode.Modelview);

        }

        private int ProcessSelect(int count, int[] index)
        {
            int Depth = 0;
            int selection = 0;
            for (int i = 1; i <= count; i++) {
                if (Depth != Math.Min(index[i * 4 - 3], Depth)) {
                    Depth = index[i * 4 - 3];
                    selection = i * 4 - 1;
                }
            }
            return (int)index[selection];
        }

        private Matrix4 GluPickMatrix(float x, float y, float width, float height, int[] viewport)
        {
            Matrix4 result = Matrix4.Identity;
            if ((width <= 0.0f) || (height <= 0.0f)) {
                return result;
            }

            float translateX = (viewport[2] - (2.0f * (x - viewport[0]))) / width;
            float translateY = (viewport[3] - (2.0f * (y - viewport[1]))) / height;
            result = Matrix4.Mult(Matrix4.CreateTranslation(translateX, translateY, 0.0f), result);
            float scaleX = viewport[2] / width;
            float scaleY = viewport[3] / height;
            result = Matrix4.Mult(Matrix4.CreateScale(scaleX, scaleY, 1.0f), result);
            return result;
        }

        private Vector3 GetPickPoint(int x, int y)
        {
            Vector2 mouse = new Vector2(x, y);

            int[] viewport = new int[4];
            Matrix4 modelViewMatrix, projectionMatrix;

            GL.GetFloat(GetPName.ModelviewMatrix, out modelViewMatrix);
            GL.GetFloat(GetPName.ProjectionMatrix, out projectionMatrix);
            GL.GetInteger(GetPName.Viewport, viewport);

            Vector4 vector = UnProject(projectionMatrix, modelViewMatrix, new Size(viewport[2], viewport[3]), mouse);

            Vector3 coords = new Vector3((int)vector.X, (int)vector.Y, (int)vector.Z);

            return coords;
        }

        Vector4 UnProject(Matrix4 projection, Matrix4 view, Size viewport, Vector2 mouse)
        {
            Vector4 vec;

            vec.X = 2.0f * mouse.X / (float)viewport.Width - 1;
            vec.Y = -(2.0f * mouse.Y / (float)viewport.Height - 1);
            //vec.X = mouse.X / (float)viewport.Width ;
            //vec.Y = -( mouse.Y / (float)viewport.Height );
            vec.Z = 0;
            vec.W = 1.0f;

            Matrix4 viewInv = Matrix4.Invert(view);
            Matrix4 projInv = Matrix4.Invert(projection);

            Vector4.Transform(ref vec, ref projInv, out vec);
            Vector4.Transform(ref vec, ref viewInv, out vec);

            if (vec.W != 0) {
                vec.X /= vec.W;
                vec.Y /= vec.W;
                vec.Z /= vec.W;
            }

            return vec;
        }

    }
}
