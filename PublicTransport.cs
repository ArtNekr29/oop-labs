using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    public interface IFareCollector
    {
        void collectFare(int amount);
    }
    public abstract class PublicTransport : IFareCollector
    {
        private int routeNumber;
        protected int capacity;

        public int RouteNumber
        {
            get { return routeNumber; }
            set { routeNumber = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { if(value > 0) capacity = value; }
        }

        public PublicTransport(int routeNumber, int capacity)
        {
            this.routeNumber = routeNumber;
            this.capacity = capacity;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Маршрут: {routeNumber}\nВместимость: {capacity}");
        }
        public abstract void collectFare(int amount);
    }

}
