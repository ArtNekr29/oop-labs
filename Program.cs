using System;
using OOP_lab1;

namespace lab1
{
    // 18
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
            Route<Bus>.ScheduleChanged += message =>
                           Console.WriteLine("Изменение расписания: " + message);

            var busRoute = new Route<Bus>("Городской маршрут");

            busRoute.AddVehicle(new Bus(1, 50, "Дизель"));
            busRoute.AddVehicle(new Bus(2, 40, "Газ"));

            busRoute.StartRoute();

            Console.WriteLine($"Эффективность маршрута: {busRoute.RouteEfficiency}");

            busRoute.ChangeSchedule("Маршрут задерживается на 10 минут.");

            Console.WriteLine($"Всего маршрутов автобусов создано: {Route<Bus>.TotalRoutesCreated}");

            Console.WriteLine("\n=== Демонстрация приведения типов ===");
            busRoute.ShowTransportInfo(new Bus(3, 45, "Электро"));
        }
    }
}


