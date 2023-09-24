using System;

// Реализация интерфейса IDeveloper для класса TruckDeveloper
class TruckDeveloper : IDeveloper
{
    public IVehicle Create()
    {
        return new Truck();
    }
}
