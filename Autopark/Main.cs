using System.Diagnostics;

namespace Autopark
{

    class Program
    {
        static void Main()
        {
            PassengerCar a = new PassengerCar("Mercedez", 1000, 1980, 5);
            Truck b = new Truck("Monster", 1000, 2010, 50, "Steve Jonson");
            List<Car> cars = new List<Car>();
            cars.Add(a);
            cars.Add(b);
            Autopark home = new Autopark("first_park", cars);
            Console.Write(home.ToString());
            return;
        }
    }
}
