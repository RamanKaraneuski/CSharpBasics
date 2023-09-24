using System;

// Реализация интерфейса IVehicle для класса Car (автомобиль)
class Car : IVehicle
{
    public void PrintInfo()
    {
        Console.WriteLine("Car: A four-wheeled vehicle.");
    }
}
