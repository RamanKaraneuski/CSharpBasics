using System;

// Реализация интерфейса IVehicle для класса Truck (грузовик)
class Truck : IVehicle
{
    public void PrintInfo()
    {
        Console.WriteLine("Truck: A heavy-duty vehicle used for transportation of goods.");
    }
}
