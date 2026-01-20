using System;

namespace lab1
{
    //"Маршрут":
    //  Класс `Route` с полями:
    //      точка отправления,
    //      точка назначения,
    //      расстояние (км),
    //      ориентировочное время в пути.
    //  Метод для расчета средней скорости. 
    class Route
    {
        private string _start;
        private string _end;
        private double _dist;
        private double _time;

        public string Start { get { return _start; } }
        public string End { get { return _end; } }
        public double Dist { 
            get { return _dist; } 
            set { 
                if (value > 0) 
                    _dist = value; 
            } 
        }
        public double Time
        {
            get { return _time; }
            set {
                if (value > 0)
                    _time = value; 
            }
        }

        public Route(string start, string end, double dist, double time)
        {
            _start = start;
            _end = end;
            _dist = dist;
            _time = time;
        }

        public double AverageSpeed()
        {
            return _dist / _time;
        }

        public void TotasTimeCalc(out double total, params double[] stopTimes)
        {
            total = 0;
            foreach (var stop in stopTimes)
            {
                total += stop;
            }
            total += _time;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация класса 
            Route route1 = new Route("Ульяновск", "Казань", 723.3, 4.5);
            Console.WriteLine($"Маршрут {route1.Start}-{route1.End} \n" +
                              $"Расстояние: {route1.Dist}км\n" +
                              $"Среднее время в пути: {route1.Time}ч");

            Console.WriteLine();
            // Изменение времени маршрута 
            route1.Time = 4;
            Console.WriteLine($"Маршрут {route1.Start}-{route1.End} \n" +
                              $"Расстояние: {route1.Dist}км\n" +
                              $"Среднее время в пути: {route1.Time}ч (изм)");

            // Средняя скорость 
            Console.WriteLine($"Средняя скорость маршрута: {route1.AverageSpeed}км/ч");

            // Работа с параметрами методов 
            double[] stops = new double[]{ 1, 0.5 };
            route1.TotasTimeCalc(out double totalTime, stops); 
            Console.WriteLine($"При добавлении {stops.Count()} остановок суммарное время составит {totalTime}ч");
        }
    }
}


