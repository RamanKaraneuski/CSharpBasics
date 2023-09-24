using System;

namespace CSharpOOP
{
    public class Table
    {
        // Table class fields
        public string Material;
        public int LegsCount;
        public bool IsFoldable;

        // Method that changes the value of the "Material" field
        public void ChangeMaterial(string newMaterial)
        {
            Material = newMaterial;
        }

        // Method that outputs data to the console
        public void DisplayDetails()
        {
            Console.WriteLine("Table Details:");
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Legs Count: " + LegsCount);
            Console.WriteLine("Is Foldable: " + IsFoldable);
        }
    }
}
