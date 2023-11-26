using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMVC.Models
{
    internal class Model
    {
        private int kilometers;
        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private int totalPrice;
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private double startPrice;
        public double StartPrice
        {
            get { return startPrice; }
            set { startPrice = value; }
        }

        public Model(View.Display display, int kilometers, string time)
        {
            Kilometers = kilometers;
            Time = time;
        }

        public Model(int kilometers, string time)
        {
            this.kilometers = kilometers;
            this.time = time;
        }

        public double CalculateCheapest()
        {
            double PricePerKilometers = 0;
            if (kilometers < 20)
            {
                startPrice = 0.7;
                if (time == "day")
                    PricePerKilometers = 0.79;
                else if (time == "night")
                    PricePerKilometers = 0.9;
            }
            if (kilometers >= 20 && kilometers <= 100)
                //nqma startprice zashtoto nqma
                PricePerKilometers = 0.09;
            if(kilometers>100)
                PricePerKilometers =  0.06;

            return PricePerKilometers;
        }

        public double CalculatePrice()
        {
           return CalculateCheapest() * kilometers + startPrice;
        }
    }
}
