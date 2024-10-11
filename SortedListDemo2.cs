using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class SortedListDemo2
    {
        static void Main()
        {
            Hashtable S = new Hashtable();
            S.Add("22SOECE11172", "Ankit");
            S.Add("22SOECE11170", "Raj");
            S.Add("22SOECE11190", "Sheilendra");
            S["22SOECE11170"] = "Anku";

            ICollection c = S.Keys;
            foreach (string t in c)
                Console.WriteLine(S[t]);
            Console.WriteLine();
        }
    }
}
