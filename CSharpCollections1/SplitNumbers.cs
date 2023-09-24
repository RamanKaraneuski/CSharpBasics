using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class SplitNumbers
    {
        public static (int[] evenNumbers, int[] oddNumbers) Split(int[] numbers)
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            var oddNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();

            return (evenNumbers, oddNumbers);
        }
    }
}