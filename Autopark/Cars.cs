using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    internal class Car
    {

        private string _mark;
        private int _power;
        private int _year;

        public string Mark { get => _mark; set => _mark = value; }
        public int Power { get => _power; set => _power = value; }
        public int Year { get => _year; set => _year = value; }

        public Car()
        {
            _mark = "not enterted";
            _power = 0;
            _year = 0;
        }
        public Car(string mark, int power, int year)
        {
            _mark = mark;
            _power = power;
            _year = year;
        }
        //реализованы для удобства пользования


        public override string ToString()
        {
            return "mark is:\t\t" + _mark.ToString() + "\npower of car is:\t" + _power.ToString() + "\nage of create is:\t" + _year.ToString();

        }

    }
    internal class PassengerCar : Car
    {
        private int _value_of_people;
        private Dictionary<string, int> _list_part = new Dictionary<string, int>();
        public PassengerCar() : base()
        {
            _value_of_people = 0;
        }
        public PassengerCar(string mark, int power, int year, int value) : base(mark, power, year)
        {
            _value_of_people = value;
        }
        //реализованы для удобства
        public int Valuepeople { get => _value_of_people; set => _value_of_people = value; }
        public Dictionary<string, int> ListDetail { get => _list_part; set => _list_part = value; }

        public void AddDetail(string name, int year)
        {
            _list_part.Add(name, year);
        }
        public int ShowYearDetil(string name)
        {
            return _list_part[name];
        }
        public void PrintDetailBook()
        {
            foreach (KeyValuePair<string, int> detail in _list_part)
            {
                Console.WriteLine(detail.Key + '\t' + detail.Value);
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nvalue of people:\t" + _value_of_people;
        }
    }
    internal class Truck : Car
    {
        private int _max_weight;
        private string _first_second_names;
        private Dictionary<string, int> _cur_weight;

        public Truck() : base() { }
        public Truck(string mark, int power, int age, int max_weight, string names) : base(mark, power, age)
        {
            _max_weight = max_weight;
            _first_second_names = names;
        }
        //реализовано для удобства
        public int Maxweight { get => _max_weight; set => _max_weight = value; }
        public string Name { get => _first_second_names; set => _first_second_names = value; }
        public Dictionary<string, int> CurWeight { get => _cur_weight; set => _cur_weight = value; }

        public void ChangeDriver(string name)
        {
            _first_second_names = name;
        }
        public void AddWeight(string name_weight, int weight)
        {
            _cur_weight[name_weight] = weight;
        }
        public void DeleteWeight(string name_weight)
        {
            _cur_weight.Remove(name_weight);
        }
        public void PrintWeight()
        {
            foreach (KeyValuePair<string, int> weight in _cur_weight)
            {
                Console.WriteLine(weight.Key + '\t' + weight.Value);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\nmax_weight:\t\t" + _max_weight + "\nDriver:\t\t\t" + _first_second_names;
        }
    }

}
