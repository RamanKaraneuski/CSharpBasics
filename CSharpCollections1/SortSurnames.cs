using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class SortSurnames
    {
        public static List<string> Sort(List<string> surnames)
        {
            return surnames.OrderBy(s => s).ToList();
        }
    }
}