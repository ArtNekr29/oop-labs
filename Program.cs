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

    // lab2 
    //Базовый класс: `PublicTransport` (Маршрут №, Вместимость).
    //Интерфейс: `IFareCollector` (метод `CollectFare(int amount)`).
    //Наследники: `Bus` (Тип топлива),`Tram` (Номер депо), `Taxi` (Тариф за км).
    //По-разному реализовать `CollectFare`.
    //Создать список `List<IFareCollector>`.

    class Program
    {
        static void Main(string[] args)
        {
            List<IFareCollector> transports = new List<IFareCollector>()
            {
                new Bus(1, 50, "Diesel"),
                new Tram(3, 100, 5),
                new Taxi(0, 3, 100)
            };

            Console.WriteLine("------- Оплата -------");
            foreach (IFareCollector transp in transports)
            {
                transp.collectFare(100);
            }

            Console.WriteLine("\n------- Информация -------");
            List<PublicTransport> transportList = new List<PublicTransport>
            {
                new Bus(2, 40, "Газ"),
                new Tram(7, 150, 1),
                new Taxi(0, 4, 30)
            };

            foreach (PublicTransport pt in transportList)
            {
                pt.Info();   
                Console.WriteLine();
            }

            Console.WriteLine("\n ------- Преобразование типов -------");
            PublicTransport ven = new Bus(54, 50, "Gas");

            if(ven is Bus)
            {
                Bus bus = (Bus)ven;
                Console.WriteLine($"Downscaling через is\n Вызов дочернего метода: {bus.FuelType}");
            }

            PublicTransport ven2 = new Taxi(0, 3, 150);
            Taxi taxi = ven2 as Taxi;
            Console.WriteLine($"Downscaling через as:\n Вызов дочернего метода: {taxi.RatePerKm}");
        }
    }
}


