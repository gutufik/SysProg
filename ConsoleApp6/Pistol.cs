using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Pistol : IRangeWeapon
    {
        public Pistol()
        {
        }

        public double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Magazine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Range { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
