using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.Prototype
{
    public abstract class User : ICloneable
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public abstract void Display();
    }
}
