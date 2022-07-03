using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public interface IRangeWeapon : IWeapon
    {
        public double Weight { get; set; }
        public int Magazine { get; set; }
        public double Range { get; set; }
    }
}
