using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public new int Product()
        {
            return x * y * z;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nZ: {z}";
        }

    }
}
