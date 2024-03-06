using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.FabricMethod
{
    public abstract class Car
    {
        public abstract string GetInfo();
    }
    public class SedanCar : Car
    {
        public override string GetInfo()
        {
            return "This is a Sedan car.";
        }
    }
    public class SUVCar : Car
    {
        public override string GetInfo()
        {
            return "This is an SUV car.";
        }
    }
}
