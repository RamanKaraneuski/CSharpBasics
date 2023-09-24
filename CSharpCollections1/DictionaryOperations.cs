using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class DictionaryOperations
    {
        public static Dictionary<string, string> FlipDictionary(Dictionary<string, string> dictionary)
        {
            return dictionary.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        }
    }
}