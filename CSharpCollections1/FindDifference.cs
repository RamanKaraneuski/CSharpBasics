using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class FindDifference
    {
        public static double CalculateDifference(double[] numbers)
        {
            double max = numbers.Max();
            double min = numbers.Min();
            double difference = max - min;

            return difference;
        }
    }
}