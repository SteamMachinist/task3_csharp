namespace task3_csharp
{
    enum FuelType
    {
        Gasoline,
        Diesel,
        Methane
    }

    internal class Engine
    {
        public double FuelConsumption { get; private set; } 
        public FuelType FuelType { get; private set; }

        public Engine(double fuelConsumption, FuelType fuelType)
        {
            FuelConsumption = fuelConsumption;
            FuelType = fuelType;
        }

        public double calculateFuelFor(double distance)
        {
            return distance * FuelConsumption / 100;
        }

        public override string? ToString()
        {
            return "Engine(fuelConsumption = " + FuelConsumption + "; fuelType = " + FuelType + ")";
        }
    }
}
