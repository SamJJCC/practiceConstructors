using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceConstructors
{
    internal class car
    {
        //fields
        string _make;
        string _model;
        int _year;
        int _mileage;

        public car()
        {
            _make = "Unassigned";
            _model = "Unassigned";
            _year = 0;
            _mileage = 0;
        }

        public car(string make, string model)
        {
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;

        }
        
        public car(string make,string model,int year,int mileage)
        {
            _make = make;
            _model = model;
            _mileage = mileage;
            _year = year;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public override string ToString()
        {
            return Year+""+" "+Make+" "+Model+" "+"-Mileage="+Mileage+"";
        }
    }
}
