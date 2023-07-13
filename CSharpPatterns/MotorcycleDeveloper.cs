using System;

// Реализация интерфейса IDeveloper для класса MotorcycleDeveloper
class MotorcycleDeveloper : IDeveloper
{
    public IVehicle Create()
    {
        return new Motorcycle();
    }
}
