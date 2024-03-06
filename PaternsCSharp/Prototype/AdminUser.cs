using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.Prototype
{
    public class AdminUser : User
    {
        public override void Display()
        {
            Console.WriteLine($"Admin User: Username - {Username}, Email - {Email}");
        }
    }
}
