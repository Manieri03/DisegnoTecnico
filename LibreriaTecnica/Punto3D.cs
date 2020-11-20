using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaTecnica
{
   public class Punto3D : Punto
   {
        public int z { get; set; }

        public Punto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
