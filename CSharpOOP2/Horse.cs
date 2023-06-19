using System;

public class Horse
{
    public string Color { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public double ManeLength { get; set; }
    public bool IsVaccinated { get; set; }

    public void UpdateVaccinationStatus(int daysSinceLastVaccination)
    {
        if (daysSinceLastVaccination > 365)
        {
            IsVaccinated = false;
            Console.WriteLine("The horse's vaccination status has been updated to not vaccinated.");
        }
        else
        {
            IsVaccinated = true;
            Console.WriteLine("The horse's vaccination status has been updated to vaccinated.");
        }
    }

    public void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("This is an internal method.");
    }

    internal static void InternalMethodCaller(Horse horse)
    {
        horse.InternalMethod();
    }
}
