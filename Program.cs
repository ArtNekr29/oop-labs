using System;
using OOP_lab1;

namespace lab1
{
    //"Маршрут":
    //  Класс `Route` с полями:
    //      точка отправления,
    //      точка назначения,
    //      расстояние (км),
    //      ориентировочное время в пути.
    //  Метод для расчета средней скорости. 

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
            Console.WriteLine($"Средняя скорость маршрута: {route1.AverageSpeed()}км/ч");

            // Работа с параметрами методов 
            double[] stops = new double[]{ 1, 0.5 };
            route1.TotasTimeCalc(out double totalTime, stops); 
            Console.WriteLine($"При добавлении {stops.Count()} остановок суммарное время составит {totalTime}ч");
        }
    }
}


