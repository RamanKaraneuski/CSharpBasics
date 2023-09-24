using System;

namespace CSharpOOP
{
    public class Horse
    {
        // Fields of class "Horse"
        public string Color;
        public int Age;
        public string Breed;
        public double ManeLength;
        public bool IsVaccinated;

        // Method that changes the value of the "IsVaccinated" field
        public void UpdateVaccinationStatus(int daysSinceLastVaccination)
        {
            if (daysSinceLastVaccination > 365)
                IsVaccinated = false;
            else
                IsVaccinated = true;
        }

        // Method that outputs data to the console
        public void DisplayDetails()
        {
            Console.WriteLine("Horse Details:");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Mane Length: " + ManeLength + " meters");
            Console.WriteLine("Vaccination Status: " + (IsVaccinated ? "Vaccinated" : "Not Vaccinated"));
        }
    }
}
