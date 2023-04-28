/*
 * Создать приложение, удовлетворяющее требованиям, приведенным в задании. Наследование применять только в тех заданиях, в которых это логически обосновано. 
 * Аргументировать принадлежность классу каждого создаваемого метода. Для каждого класса должно быть не менее 2 свойств.
 * 
 * 2. Создать объект класса Автомобиль, используя классы Колесо, Двигатель. 
 * Методы: ехать, заправляться, менять колесо, вывести марку автомобиля.
 */

namespace task3_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(11.7, FuelType.Diesel);
            List<Wheel> wheels = new List<Wheel> { new Wheel("Michelin", 50000), new Wheel("Michelin", 50000), new Wheel("Michelin", 50000), new Wheel("Michelin", 50000)};
            Car car = new Car("BMW", 60, engine, wheels);
            Console.WriteLine(car.ToString() + "\n");

            Console.WriteLine(car.Drive(250) + "\n");
            Console.WriteLine(car.ToString() + "\n");

            Console.WriteLine(car.Drive(350) + "\n");
            Console.WriteLine(car.ToString() + "\n");

            car.Engine = new Engine(8.0, FuelType.Diesel);
            Console.WriteLine(car.ToString() + "\n");
            Console.WriteLine(car.Drive(350) + "\n");
            Console.WriteLine(car.ToString() + "\n");

            car.Refuel(25);
            Console.WriteLine(car.ToString());

            car.ChangeWheel(0, new Wheel("Pirelli", 60000));
            Console.WriteLine(car.ToString());
        }
    }
}