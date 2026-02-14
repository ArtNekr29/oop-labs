using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    public class Tram : PublicTransport
    {
        public int DepotNumber { get; set; }
        public Tram(int depotNumber, int capacity, int routeNumber)
            : base(routeNumber, capacity)
        {
            DepotNumber = depotNumber;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Депо №{DepotNumber}");
        }
        public override void collectFare(int amount)
        {
            Console.WriteLine($"В трамвае собрано {amount * 36.5} руб.");
        }
    }
}
