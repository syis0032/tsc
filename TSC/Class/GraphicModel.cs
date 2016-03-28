using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;
using OpenTK;

namespace TSC.Class
{

    public class Coord3D
    {
        public float x = 0, y = 0, z = 0;
        public Coord3D() { }
        public Coord3D(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }

    public abstract class GraphicModel
    {
        private bool selected = false;
        private Coord3D position = new Coord3D();
        private Coord3D rotation = new Coord3D();
        private Coord3D scale = new Coord3D(1, 1, 1);
        public float xMin = 0, yMin = 0, zMin = 0, xMax = 0, yMax = 0, zMax = 0;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        public Coord3D Position
        {
            get { return position; }
            set { position = value; }
        }
        public Coord3D Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }
        public Coord3D Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public virtual bool Changed
        {
            get { return false; }
        }

        abstract public void Paint();

        public virtual Vector3 getCenter()
        {
            return new Vector3(0, 0, 0);
        }

        public virtual void Clear() { }
        public virtual void ReduceQuality() { }
        public virtual void ResetQuality() { }
    }
}
