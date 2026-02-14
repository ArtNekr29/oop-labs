using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    public class Bus : PublicTransport
    {
        public string FuelType { get; set; }
        public Bus(int routeNumber, int capacity, string fuelType)
            : base(routeNumber, capacity)
        {
            FuelType = fuelType;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Топливо: {FuelType}");
        }
        public override void collectFare(int amount)
        {
            Console.WriteLine($"Собрано {amount * 37} руб.");
        }
    }
}
