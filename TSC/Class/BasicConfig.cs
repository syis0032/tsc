using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSC.Class
{
    public class BasicConfig
    {
        public string workDirectory;
        public string slicerLocation;
        public int printSizeX;
        public int printSizeY;
        public int printSizeZ;
        public int typeIndex;
        public MachineType[] type;

        public BasicConfig()
        {
            typeIndex = 0;
            initMachineType();
            typeChange();
            workDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + "\\Test";
            slicerLocation = "";
        }

        public void typeChange()
        {
            printSizeX = type[typeIndex].sizeX;
            printSizeY = type[typeIndex].sizeY;
            printSizeZ = type[typeIndex].sizeZ;
        }
        /*machine type definition*/
        void initMachineType()
        {
            type = new MachineType[2];
            type[0] = new MachineType("S1", 400, 400, 200);
            type[1] = new MachineType("S2", 150, 150, 100);
        }
    }

    public struct MachineType
    {
        public string Name;
        public int sizeX;
        public int sizeY;
        public int sizeZ;
        public MachineType(string Name, int sizeX, int sizeY, int sizeZ)
        {
            this.Name = Name;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.sizeZ = sizeZ;
        }
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
