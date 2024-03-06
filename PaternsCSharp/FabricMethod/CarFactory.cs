using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.FabricMethod
{
    public abstract class CarFactory
    {
        public abstract Car CreateCar();
    }
    public class SedanCarFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new SedanCar();
        }
    }
    public class SUVCarFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new SUVCar();
        }
    }
}
