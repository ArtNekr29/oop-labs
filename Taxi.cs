using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    public class Taxi : PublicTransport
    {
        public double RatePerKm { get; set; }

        public Taxi(int routeNumber, int capacity, double ratePerKm)
            : base(routeNumber, capacity)
        {
            RatePerKm = ratePerKm;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Цена поездки за км: {RatePerKm}");
        }

        public override void collectFare(int dist)
        {
            double total = dist * RatePerKm;
            Console.WriteLine($"Такси: поездка {dist} км, к оплате {total} руб.");
        }
    }
}
