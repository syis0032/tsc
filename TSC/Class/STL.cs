using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TSC.Class
{
    public class STLTriangle : IComparer<STLTriangle>
    {
        public Vector3 normal;
        public Vector3 p1, p2, p3;

        public int Compare(STLTriangle x, STLTriangle y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    float xmin = Math.Min(x.p1.Z, Math.Min(x.p2.Z, x.p3.Z));
                    float ymin = Math.Min(y.p1.Z, Math.Min(y.p2.Z, y.p3.Z));

                    return xmin < ymin ? -1 : (xmin > ymin ? 1 : 0);
                }
            }
        }
    }

    public class STL : GraphicModel
    {
        public LinkedList<STLTriangle> list;
        public string name = "Noname";
        public string filename = "";
        long lastModified = 0;
        public bool outside = false;
        public Matrix4 trans;
        public STL copySTL()
        {
            STL stl = new STL();
            stl.filename = filename;
            stl.name = name;
            stl.lastModified = lastModified;
            stl.list = list;
            stl.Position.x = Position.x;
            stl.Position.y = Position.y + 5 + yMax - yMin;
            stl.Position.z = Position.z;
            stl.Scale.x = Scale.x;
            stl.Scale.y = Scale.y;
            stl.Scale.z = Scale.z;
            stl.Rotation.x = Rotation.x;
            stl.Rotation.y = Rotation.y;
            stl.Rotation.z = Rotation.z;
            stl.Selected = false;
            stl.UpdateMatrix();
            return stl;
        }

        float[] points = null;
        float[] normals = null;
        int[] triangles = null;
        int[] edges = null;
        int[] bufs = null;

        //bool graphicSwitch = true;

        public override string ToString()
        {
            return name;
        }

        public void Load(string file)
        {
            list = new LinkedList<STLTriangle>();
            filename = file;

            try
            {
                DateTime lastModified2 = File.GetLastWriteTime(filename);
                lastModified = lastModified2.Ticks;
                FileStream f = File.OpenRead(file);
                byte[] header = new byte[80];
                ReadArray(f, header);
                BinaryReader r = new BinaryReader(f);
                int nTri = r.ReadInt32();
                if (f.Length != 84 + nTri * 50)
                {
                    f.Close();
                    LoadText(file);
                }
                else
                {
                    xMin = yMin = zMin = float.MaxValue;
                    xMax = yMax = zMax = float.MinValue;

                    for (int i = 0; i < nTri; i++)
                    {

                        STLTriangle tri = new STLTriangle();
                        tri.normal = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                        tri.p1 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                        tri.p2 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                        tri.p3 = new Vector3(r.ReadSingle(), r.ReadSingle(), r.ReadSingle());
                        tri.normal = Vector3.Normalize(tri.normal);
                        list.AddLast(tri);
                        r.ReadUInt16();


                        CalculateMinMaxPoint(ref tri.p1);
                        CalculateMinMaxPoint(ref tri.p2);
                        CalculateMinMaxPoint(ref tri.p3);

                    }
                    r.Close();
                    f.Close();
                }
                FileInfo info = new FileInfo(file);
                name = info.Name;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error reading STL file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitPos()
        {
            trans = Matrix4.Identity;

            Position.x = 0.5f * (xMax + xMin);
            Position.y = 0.5f * (yMax + yMin);
            Position.z = zMin;

            Vector3 center = new Vector3(Position.x, Position.y, Position.z);

            xMin = yMin = zMin = float.MaxValue;
            xMax = yMax = zMax = float.MinValue;

            foreach (STLTriangle tri in list)
            {
                tri.p1 -= center;
                tri.p2 -= center;
                tri.p3 -= center;

                CalculateMinMaxPoint(ref tri.p1);
                CalculateMinMaxPoint(ref tri.p2);
                CalculateMinMaxPoint(ref tri.p3);
            }

            Position.x = 0.5f * (xMax + xMin);
            Position.y = 0.5f * (yMax + yMin);
            Position.z = zMin;

        }

        private void CalculateMinMaxPoint(ref Vector3 v)
        {
            float x, y, z;
            x = v.X;
            y = v.Y;
            z = v.Z;
            xMin = Math.Min(xMin, x);
            xMax = Math.Max(xMax, x);
            yMin = Math.Min(yMin, y);
            yMax = Math.Max(yMax, y);
            zMin = Math.Min(zMin, z);
            zMax = Math.Max(zMax, z);
        }

        public void UpdateMatrix()
        {
            Matrix4 transl = Matrix4.CreateTranslation(Position.x, Position.y, Position.z);
            Matrix4 scale = Matrix4.CreateScale(Scale.x, Scale.y, Scale.z);
            Matrix4 rotx = Matrix4.CreateRotationX(Rotation.x * (float)Math.PI / 180.0f);
            Matrix4 roty = Matrix4.CreateRotationY(Rotation.y * (float)Math.PI / 180.0f);
            Matrix4 rotz = Matrix4.CreateRotationZ(Rotation.z * (float)Math.PI / 180.0f);
            trans = Matrix4.Mult(scale, rotx);
            trans = Matrix4.Mult(trans, roty);
            trans = Matrix4.Mult(trans, rotz);
            trans = Matrix4.Mult(trans, transl);
        }

        public void TransformPoint(ref Vector3 v, out float x, out float y, out float z)
        {
            Vector4 v4 = new Vector4(v, 1);
            x = Vector4.Dot(trans.Column0, v4);
            y = Vector4.Dot(trans.Column1, v4);
            z = Vector4.Dot(trans.Column2, v4);
        }

        public void ReadArray(Stream stream, byte[] data)
        {
            int offset = 0;
            int remaining = data.Length;
            while (remaining > 0)
            {
                int read = stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
        }

        private void LoadText(string file)
        {
            string text = System.IO.File.ReadAllText(file);
            int lastP = 0, p, pend, normal, outer, vertex, vertex2;
            while ((p = text.IndexOf("facet", lastP)) > 0)
            {
                pend = text.IndexOf("endfacet", p + 5);
                normal = text.IndexOf("normal", p) + 6;
                outer = text.IndexOf("outer loop", normal);
                STLTriangle tri = new STLTriangle();
                tri.normal = extractVector(text.Substring(normal, outer - normal));
                tri.normal = Vector3.Normalize(tri.normal);
                outer += 10;
                vertex = text.IndexOf("vertex", outer) + 6;
                vertex2 = text.IndexOf("vertex", vertex);
                tri.p1 = extractVector(text.Substring(vertex, vertex2 - vertex));
                vertex2 += 7;
                vertex = text.IndexOf("vertex", vertex2);
                tri.p2 = extractVector(text.Substring(vertex2, vertex - vertex2));
                vertex += 7;
                vertex2 = text.IndexOf("endloop", vertex);
                tri.p3 = extractVector(text.Substring(vertex, vertex2 - vertex));
                lastP = pend + 8;
                if (AssertVector3NotNaN(tri.normal) && AssertVector3NotNaN(tri.p1) && AssertVector3NotNaN(tri.p2) && AssertVector3NotNaN(tri.p3))
                {
                    if (AssertMinDistance(tri.p1, tri.p2) && AssertMinDistance(tri.p1, tri.p3) && AssertMinDistance(tri.p2, tri.p3))
                        list.AddLast(tri);
                }
            }
        }

        private Vector3 extractVector(string s)
        {
            Vector3 v = new Vector3();
            s = s.Trim();
            int p = s.IndexOf(' ');
            if (p < 0) throw new Exception("Format error");
            float.TryParse(s.Substring(0, p), NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out v.X);
            s = s.Substring(p).Trim();
            p = s.IndexOf(' ');
            if (p < 0) throw new Exception("Format error");
            float.TryParse(s.Substring(0, p), NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out v.Y);
            s = s.Substring(p).Trim();
            float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out v.Z);
            return v;
        }

        private bool AssertVector3NotNaN(Vector3 v)
        {
            if (float.IsNaN(v.X) || float.IsNaN(v.Y) || float.IsNaN(v.Z))
            {
                //Main.conn.log("NaN value in STL file import", false, 2);
                return false;
            }
            if (float.IsInfinity(v.X) || float.IsInfinity(v.Y) || float.IsInfinity(v.Z))
            {
                //Main.conn.log("Infinity value in STL file import", false, 2);
                return false;
            }
            return true;
        }

        private bool AssertMinDistance(Vector3 a, Vector3 b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            double dz = a.Z - b.Z;
            return dx * dx + dy * dy + dz * dz > 1e-8;
        }


        public override Vector3 getCenter()
        {
            return new Vector3(0.5f * (xMin + xMax), 0.5f * (yMin + yMax), 0.5f * (zMin + zMax));
        }

        public override void Paint()
        {

            GL.Enable(EnableCap.Normalize);

            bool useVBOs = Main.graphicConfig.drawMethod == 2;

            if(bufs != null && !useVBOs)
            {
                GL.DeleteBuffers(4, bufs);
                bufs = null;
            }

            if (((useVBOs && bufs == null)) || (points == null && Main.graphicConfig.drawMethod == 1))
            {

                bufs = new int[4];
                GL.GenBuffers(4, bufs);


                int nv = list.Count * 3;
                points = new float[nv * 3];
                normals = new float[nv * 3];
                triangles = new int[nv];
                edges = new int[2 * nv];


                int pos = 0;
                int epos = 0;
                int tpos = 0;
                int ppos = 0;
                foreach (STLTriangle tri in list)
                {
                    edges[epos++] = pos;
                    edges[epos++] = pos + 1;
                    edges[epos++] = pos + 1;
                    edges[epos++] = pos + 2;
                    edges[epos++] = pos + 2;
                    edges[epos++] = pos;
                    triangles[tpos++] = pos;
                    triangles[tpos++] = pos + 1;
                    triangles[tpos++] = pos + 2;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p1.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p1.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p1.Z;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p2.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p2.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p2.Z;
                    normals[ppos] = tri.normal.X;
                    points[ppos++] = tri.p3.X;
                    normals[ppos] = tri.normal.Y;
                    points[ppos++] = tri.p3.Y;
                    normals[ppos] = tri.normal.Z;
                    points[ppos++] = tri.p3.Z;
                    pos += 3;
                }

                if (useVBOs)
                {
                    GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[0]);
                    GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(points.Length * sizeof(float)), points, BufferUsageHint.StaticDraw);
                    GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[1]);
                    GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(normals.Length * sizeof(float)), normals, BufferUsageHint.StaticDraw);
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[2]);
                    GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(triangles.Length * sizeof(int)), triangles, BufferUsageHint.StaticDraw);
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[3]);
                    GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(edges.Length * sizeof(int)), edges, BufferUsageHint.StaticDraw);
                }
            }

            if(Selected)
                GL.Color3(Main.graphicConfig.SelFaceColor.BackColor);
            else
                GL.Color3(Main.graphicConfig.FaceColor.BackColor);

            if(Main.graphicConfig.drawMethod > 0)
            {
                GL.EnableClientState(ArrayCap.VertexArray);
                GL.EnableClientState(ArrayCap.NormalArray);

                if(Main.graphicConfig.drawMethod == 2)
                {
                    GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[0]);
                    GL.VertexPointer(3, VertexPointerType.Float, 0, 0);
                    GL.BindBuffer(BufferTarget.ArrayBuffer, bufs[1]);
                    GL.NormalPointer(NormalPointerType.Float, 0, 0);
                    GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[2]);

                    if (Main.graphicConfig.cb_faces.Checked)
                    {
                        GL.DrawElements(PrimitiveType.Triangles, triangles.Length, DrawElementsType.UnsignedInt, 0);
                    }

                    if (Main.graphicConfig.cb_edges.Checked)
                    {
                        GL.Color3(Main.graphicConfig.EdgeColor.BackColor);
                        GL.BindBuffer(BufferTarget.ElementArrayBuffer, bufs[3]);
                        GL.DrawElements(PrimitiveType.Lines, edges.Length, DrawElementsType.UnsignedInt, 0);
                    }
                }
                else
                {
                    GL.VertexPointer(3, VertexPointerType.Float, 0, points);
                    GL.NormalPointer(NormalPointerType.Float, 0, normals);
                    if (Main.graphicConfig.cb_faces.Checked)
                    {
                        GL.DrawElements(PrimitiveType.Triangles, triangles.Length, DrawElementsType.UnsignedInt, triangles);
                    }
                    if (Main.graphicConfig.cb_edges.Checked)
                    {
                        GL.Color3(Main.graphicConfig.EdgeColor.BackColor);
                        GL.DrawElements(PrimitiveType.Lines, edges.Length, DrawElementsType.UnsignedInt, edges);
                    }
                }

                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.NormalArray);
            }
            else
            {
                if (Main.graphicConfig.cb_faces.Checked)
                {
                    GL.Begin(PrimitiveType.Triangles);
                    foreach (STLTriangle tri in list)
                    {
                        GL.Normal3(tri.normal);
                        GL.Vertex3(tri.p1);
                        GL.Vertex3(tri.p2);
                        GL.Vertex3(tri.p3);
                    }
                    GL.End();
                }
                if (Main.graphicConfig.cb_edges.Checked)
                {
                    GL.Color3(Main.graphicConfig.EdgeColor.BackColor);
                    GL.Begin(PrimitiveType.Lines);
                    foreach (STLTriangle tri in list)
                    {
                        GL.Vertex3(tri.p1);
                        GL.Vertex3(tri.p2);
                        GL.Vertex3(tri.p2);
                        GL.Vertex3(tri.p3);
                        GL.Vertex3(tri.p3);
                        GL.Vertex3(tri.p1);
                    }
                    GL.End();
                }
            }

            if (Selected) {

                GL.Disable(EnableCap.Lighting);
                DrawMoveGuide();

            }

            //    GL.Enable(EnableCap.Blend);
            //    GL.DepthMask(false);
            //    GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.DstColor);

            //    GL.Color4(0.05f, 0.05f, 0.05f, 20f);

            //    GL.DrawElements(BeginMode.Triangles, triangles.Length, DrawElementsType.UnsignedInt, 0);

            //    GL.DepthMask(true);
            //    GL.Disable(EnableCap.Blend);



            GL.Disable(EnableCap.Normalize);

        }

        void DrawMoveGuide()
        {
            Vector3 Mcenter = getCenter();
            Vector3 MoveGuideX = new Vector3(Mcenter.X + (xMax - xMin) / 2, Mcenter.Y, Mcenter.Z);
            Vector3 MoveGuideY = new Vector3(Mcenter.X, Mcenter.Y + (yMax - yMin) / 2, Mcenter.Z);
            Vector3 MoveGuideZ = new Vector3(Mcenter.X, Mcenter.Y, Mcenter.Z + (zMax + zMin) / 2);
            GL.LineWidth(5);
            GL.Color3(Color.Red);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(MoveGuideX);
            MoveGuideX.X += 20;
            GL.Vertex3(MoveGuideX);

            GL.Color3(Color.Green);
            GL.Vertex3(MoveGuideY);
            MoveGuideY.Y += 20;
            GL.Vertex3(MoveGuideY);

            GL.Color3(Color.Blue);
            GL.Vertex3(MoveGuideZ);
            MoveGuideZ.Z += 20;
            GL.Vertex3(MoveGuideZ);
            GL.End();
            GL.LineWidth(1);
        }
    }
}
