using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportMVC.Models;
using TransportMVC.View;

namespace TransportMVC.Controllers
{
   internal class Controller
    {
        private Display display;
        private Model models;

        public Controller()
        {
            display = new Display();
            models = new Model(display.kilometers, display.time);
            display.TotalPrice = models.CalculatePrice();
            display.ShowCheapestWayToTravel();
        }
    }
}
