using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLinq
{
    class Program
    {
        static void Main()
        {
            #region Task1
            List<int> numbers = new List<int> { 12, 5, 9, 18, 7, 21, 15, 4, 10, 27 };

            var divisibleByThree = from num in numbers
                                   where num % 3 == 0
                                   select num;

            Console.WriteLine("Task 1: Numbers divisible by 3:");
            foreach (var num in divisibleByThree)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            #endregion

            #region Task2
            List<int> numbers2 = Enumerable.Range(7, 10).ToList();
            for (int i = 0; i < numbers2.Count / 2; i++)
            {
                numbers2[i] = -numbers2[i];
            }

            var negativeLessThanTen = numbers2.Where(num => num < 10 && num < 0);

            Console.WriteLine("Task 2: Negative numbers less than 10:");
            foreach (var num in negativeLessThanTen)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            #endregion

            #region Task3
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

            var evenLengthNames = from name in names
                                  where name.Length % 2 == 0
                                  orderby name
                                  select name;

            Console.WriteLine("Task 3: Names with even length (sorted alphabetically):");
            foreach (var name in evenLengthNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            #endregion

            #region Task4
            List<string> cities = new List<string> { "Moscow", "London", "Madrid", "Paris", "Rome", "Berlin" };
            char startLetter = 'M';
            char endLetter = 'd';

            var filteredCities = cities.Where(city =>
                                           city.StartsWith(startLetter.ToString(), StringComparison.OrdinalIgnoreCase) &&
                                           city.EndsWith(endLetter.ToString(), StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Task 4: Cities that start with 'M' and end with 'd':");
            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
            #endregion

            #region Task5
            Console.WriteLine("Task 5: Enter a string with words in uppercase and lowercase:");
            string inputString = Console.ReadLine();

            var words = inputString.Split(' ');
            var uppercaseWords = words.Where(word => word == word.ToUpper());

            Console.WriteLine("Words in uppercase:");
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            #endregion

            #region Task6
            List<int> numbers3 = new List<int> { 1, 2, 3, 4, 2, 5, 6, 3, 4, 7 };

            var distinctNumbers = numbers3.Distinct().Reverse();

            Console.WriteLine("Task 6: Distinct numbers in reverse order:");
            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            #endregion

            #region Task7
            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Task 7: Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            bool numberExists = numbers4.Contains(userInput);

            if (numberExists)
            {
                Console.WriteLine("The number exists in the collection.");
            }
            else
            {
                Console.WriteLine("The number does not exist in the collection.");
            }
            Console.WriteLine();
            #endregion

            #region Task8
            List<string> strings = new List<string> { "abc", "defg", "hijklm" };

            int totalLength = strings.Sum(str => str.Length);

            Console.WriteLine("Task 8: Total length of all strings: " + totalLength);

            if (totalLength > 5)
            {
                Console.WriteLine("First element: " + strings.First());
                Console.WriteLine("Last element: " + strings.Last());
            }
            Console.WriteLine();
            #endregion

            #region Task9
            List<string> colors = new List<string> { "bald", "brown", "yellow" };

            var otterCollection = colors.Select(color => new Otter { Color = color }).ToList();

            Console.WriteLine("Task 9: Otter collection (color property):");
            foreach (var otter in otterCollection)
            {
                Console.WriteLine("Color: " + otter.Color);
            }
            Console.WriteLine();
            #endregion

            #region Task10
            List<Otter> otters = new List<Otter>
        {
            new Otter { Color = "bald", Age = 5 },
            new Otter { Color = "brown", Age = 3 },
            new Otter { Color = "yellow", Age = 2 }
        };

            var otterColors = otters.Select(otter => otter.Color);

            Console.WriteLine("Task 10: Otter colors:");
            foreach (var color in otterColors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    class Otter
    {
        public string Color { get; set; }
        public int Age { get; set; }
    }

}