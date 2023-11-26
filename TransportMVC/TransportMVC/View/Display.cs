using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMVC.View
{
    internal class Display
    {
        public int kilometers { get; set; }
        public string time { get; set; }
        public double TotalPrice { get; set; }

        public Display()
        {
            time = " ";
            kilometers = 0;
            TotalPrice = 0;
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter the kilometers yoi will travel: ");
            kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day or night");
            time = Console.ReadLine();
        }

        public void ShowCheapestWayToTravel()
        {
            Console.WriteLine("Total price is : {0:F2} lv", TotalPrice);
        }
    }


}
