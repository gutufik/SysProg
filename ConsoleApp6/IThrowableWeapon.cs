using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public interface IThrowableWeapon : IWeapon
    {
        public double RadiusOfDefeat { get; set; }
    }
}
