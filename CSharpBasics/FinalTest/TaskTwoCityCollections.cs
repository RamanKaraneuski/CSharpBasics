using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.FinalTest
{
    class TaskTwoCityCollections
    {
        static void Main()
        {
            List<string> cities = new List<string>
        {
            "New York",
            "Los Angeles",
            "Chicago",
            "Houston",
            "Miami"
        };

            var evenLengthCities = cities.Where(city => city.Length % 2 == 0);

            var resultCities = evenLengthCities.Select(city =>
            {
                char[] cityChars = city.ToCharArray();
                if (cityChars.Length > 0)
                {

                    cityChars[0] = 'X';
                }
                return new string(cityChars);
            })
                .Select(city => city.Substring(0, Math.Min(city.Length, 3)));

            foreach (var city in resultCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}