using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class DictionaryDemo
    {
        static void Main()
        {
            Dictionary<string, string> S = new Dictionary<string, string>();
            S.Add("22SOECE11172", "Ankit");
            S.Add("22SOECE11170", "Raj");
            S.Add("22SOECE11190", "Sheilendra");
            S["22SOECE11170"] = "Anku";

            ICollection<string> c = S.Keys;
            foreach (string t in c)
                Console.WriteLine(S[t]);

            Console.ReadKey();
        }
    }
}
