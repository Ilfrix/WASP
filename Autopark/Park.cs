using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class Autopark
    {
        private string _name_park;
        private List<Car> _cars = new List<Car>();

        public Autopark(string name_park, List<Car> cars)
        {
            _name_park = name_park;
            _cars = cars;
        }
        public string Name { get => _name_park; set => _name_park = value; }
        public List<Car> ListCars { get => _cars; set => _cars = value; }
        public override string ToString()
        {
            string info = "";
            foreach (Car car in _cars)
            {
                info += car.ToString() + "\n\n"; //проверить на работу функций Truck и PassengerCar
            }
            return info;
        }
    }
}
