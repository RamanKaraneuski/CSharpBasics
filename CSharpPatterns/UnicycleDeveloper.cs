using System;

// Реализация интерфейса IDeveloper для класса UnicycleDeveloper
class UnicycleDeveloper : IDeveloper
{
    public IVehicle Create()
    {
        return new Unicycle();
    }
}
