using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial15Dey
{
    public class Vehicle
    {
        public virtual int DistanceCovered()
        {
            return 0;
        }
    }

    public class PetrolCar : Vehicle
    {
        public override int DistanceCovered() {
            return 200;
        }
    }

    public class ElectricCar : Vehicle
    {
        public override int DistanceCovered() {
            return 350;
        }
    }
}
