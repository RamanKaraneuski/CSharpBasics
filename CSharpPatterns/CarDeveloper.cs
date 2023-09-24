using System;

// Реализация интерфейса IDeveloper для класса CarDeveloper
class CarDeveloper : IDeveloper
{
    public IVehicle Create()
    {
        return new Car();
    }
}
