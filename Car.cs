using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task3_csharp
{
    internal class Car
    {
        public string Brand { get; private set; }
        public double MaxFuelLevel { get; private set; }
        public double FuelLevel { get; private set; }
        
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; private set; }

        public Car(string brand, double maxFuelLevel, Engine engine, List<Wheel> wheels)
        {
            Brand = brand;
            MaxFuelLevel = maxFuelLevel;
            FuelLevel = maxFuelLevel;
            Engine = engine;
            Wheels = wheels;
        }

        public string Drive(double distance)
        {
            double neededFuel = Engine.calculateFuelFor(distance);
            if (FuelLevel >= neededFuel)
            {
                FuelLevel -= neededFuel;
                foreach (Wheel wheel in Wheels)
                {
                    wheel.Drive(distance);
                }
                return "Car has driven " + distance + " km using " + Math.Round(neededFuel, 2) + " litres of fuel";
            }
            else
            {
                return "Not enough fuel to drive " + distance + " km, need " + Math.Round(neededFuel, 2) + " litres of fuel, but has only " + Math.Round(FuelLevel, 2);
            }
        }

        public void Refuel(double add)
        {
            FuelLevel += add;
            if (FuelLevel > MaxFuelLevel) { FuelLevel= MaxFuelLevel; }
        }

        public void ChangeWheel(int number, Wheel newWheel)
        {
            Wheels[number] = newWheel;
        }

        public override string? ToString()
        {
            string car = "Car(\n";
            car += "    brand = " + Brand + "\n";
            car += "    fuel = " + Math.Round(FuelLevel, 2)  + "/" + MaxFuelLevel + "\n";
            car += "    " + Engine.ToString() + "\n";
            car += "    wheels(\n";
            foreach (Wheel wheel in Wheels)
            {
                car += "        " + wheel.ToString() + "\n";
            }
            car += ")";
            return car;
        }
    }
}
