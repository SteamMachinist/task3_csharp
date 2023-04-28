using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_csharp
{
    internal class Wheel
    {
        public string Brand { get; private set; }
        public double RemainingLimit { get; private set; }

        public Wheel(string brand, double remainingLimit)
        {
            Brand = brand;
            RemainingLimit = remainingLimit;
        }

        public void Drive(double distance)
        {
            RemainingLimit -= distance;
        }

        public override string? ToString()
        {
            return "Wheel(brand = " + Brand + "; remainingLimit = " + RemainingLimit + ")";
        }
    }
}
