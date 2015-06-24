using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Vehicle
    {
        private string _make;
        private string _model;
        private int _elapsedMilage;
        private int _marketPrice;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int ElapsedMilage
        {
            get { return _elapsedMilage; }
            set { _elapsedMilage = value; }
        }

        public int MarketPrice
        {
            get { return _marketPrice; }
            set { _marketPrice = value; }
        }

        public string Drive(int kilometers)
        {
            _elapsedMilage += kilometers;


            string result;
            result = "The " + Make +" " + Model+ " now has " + _elapsedMilage + " kilometers, and market price is " + 
                _marketPrice + "€.";
            return result;
        }

    }
