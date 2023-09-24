using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.FinalTest
{
    public class TaskThreeGeneric
    {
        public static void PrintValue<T>(T value)
        {
            Console.WriteLine(value);
        }

        static void Main()
        {
            int intValue = 42;
            double doubleValue = 3.14;
            string stringValue = "Hello, world!";

            PrintValue(intValue);
            PrintValue(doubleValue);
            PrintValue(stringValue);
        }
    }
}
