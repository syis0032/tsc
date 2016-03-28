using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace TSC.Class
{
    public class GraphicView
    {
        public float zoom = 1.0f;
        public float rotX = -45, rotY = 0;
        public Vector3 Center;
        public Vector3 viewPoint;
        public float nearDist, farDist, aspectRatio, nearHeight;
        public Matrix4 persp, lookAt;
        public LinkedList<GraphicModel> models;

        public GraphicView()
        {
            Center = new Vector3(0, 0, 0);
            viewPoint = new Vector3(0, 0, 1.7f * (float)Math.Sqrt(Main.basicConfig.printSizeX * Main.basicConfig.printSizeX
                                                                + Main.basicConfig.printSizeY * Main.basicConfig.printSizeY 
                                                                + Main.basicConfig.printSizeZ * Main.basicConfig.printSizeZ));
            models = new LinkedList<GraphicModel>();
        }
    }
}
