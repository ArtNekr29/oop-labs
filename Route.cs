using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    public class Route<T> where T : PublicTransport
    {
        public List<T> Vehicles { get; private set; } = new List<T>();

        public string RouteName { get; set; }

        public static int TotalRoutesCreated = 0;

        public static event Action<string> ScheduleChanged;

        public Route(string routeName)
        {
            RouteName = routeName;
            TotalRoutesCreated++;
        }

        public void AddVehicle(T vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void StartRoute()
        {
            Console.WriteLine($"Маршрут {RouteName} начал движение.");
            foreach (var v in Vehicles)
            {
                v.Info();
            }
        }

        public double RouteEfficiency
        {
            get
            {
                if (Vehicles.Count == 0) return 0;
                int totalCapacity = 0;
                foreach (var v in Vehicles)
                    totalCapacity += v.Capacity;

                return (double)totalCapacity / Vehicles.Count;
            }
        }

        public void ChangeSchedule(string message)
        {
            ScheduleChanged?.Invoke(message);
        }

        public void ShowTransportInfo<U>(U transport) where U : PublicTransport
        {
            PublicTransport pt = transport;

            pt.Info();

            if (pt is Bus)
            {
                Bus bus = (Bus)pt;
                Console.WriteLine("Это автобус с топливом: " + bus.FuelType);
            }
        }
    }
}
