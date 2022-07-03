using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public interface IWeapon
    {
        public int Damage { get; set; }

        public void Attack();
    }
}
