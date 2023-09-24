using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCollections1
{

    public class Program
    {
        public static void Main()
        {
            #region Task 1
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = SplitNumbers.Split(numbers);

            Console.WriteLine("Even numbers:");
            PrintArray(result.evenNumbers);

            Console.WriteLine("Odd numbers:");
            PrintArray(result.oddNumbers);

            Console.WriteLine();
            #endregion

            #region Task 2
            double[] realNumbers = { 1.5, 2.8, 0.3, 4.7, 2.1 };
            var difference = FindDifference.CalculateDifference(realNumbers);
            Console.WriteLine("Difference between max and min numbers: " + difference);
            Console.WriteLine();
            #endregion

            #region Task 3
            List<string> surnames = new List<string> { "Smith", "Johnson", "Brown", "Taylor" };
            var sortedSurnames = SortSurnames.Sort(surnames);
            Console.WriteLine("Sorted surnames:");
            PrintList(sortedSurnames);
            Console.WriteLine();
            #endregion

            #region Task 4
            List<Citizens.Citizen> citizens = new List<Citizens.Citizen>
            {
                new Citizens.Citizen("John", "Smith", "Doe", new DateTime(1985, 10, 15), "123 Main St"),
                new Citizens.Citizen("Jane", "Doe", "Johnson", new DateTime(1992, 5, 3), "456 Elm St"),
                new Citizens.Citizen("Robert", "Brown", "Taylor", new DateTime(1978, 12, 8), "789 Oak St"),
                new Citizens.Citizen("Mary", "Johnson", "Smith", new DateTime(1990, 7, 21), "456 Elm St")
            };

            string address = "456 Elm St";
            var voters = Citizens.GetVotersByAddress(citizens, address);

            Console.WriteLine("Voters at address " + address + ":");
            PrintList(voters);
            Console.WriteLine();
            #endregion

            #region Task 5
            Dictionary<string, string> countriesAndCapitals = new Dictionary<string, string>
            {
                { "Russia", "Moscow" },
                { "USA", "Washington D.C." },
                { "France", "Paris" },
                { "Japan", "Tokyo" },
                { "Brazil", "Brasília" }
            };

            var capitalsAndCountries = DictionaryOperations.FlipDictionary(countriesAndCapitals);

            Console.WriteLine("Original dictionary:");
            PrintDictionary(countriesAndCapitals);

            Console.WriteLine("Flipped dictionary:");
            PrintDictionary(capitalsAndCountries);
            #endregion
        }

        public static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }

        public static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintList(List<Citizens.Citizen> list)
        {
            foreach (var citizen in list)
            {
                Console.WriteLine(citizen);
            }
        }

        public static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
    }
}