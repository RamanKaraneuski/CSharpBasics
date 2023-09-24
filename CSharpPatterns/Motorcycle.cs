using System;

// Реализация интерфейса IVehicle для класса Motorcycle (мотоцикл)
class Motorcycle : IVehicle
{
    public void PrintInfo()
    {
        Console.WriteLine("Motorcycle: A two-wheeled vehicle.");
    }
}
