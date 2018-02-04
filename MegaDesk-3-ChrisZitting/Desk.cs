using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ChrisZitting
{
    class Desk
    {

        public const double MAX_WIDTH = 96;
        public double Width { get; set; }
        public double Depth { get; set; }
        public int NumDrawers { get; set; }
        public SurfaceMaterial Material { get; set; }

    }

    public enum SurfaceMaterial
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    }
}
