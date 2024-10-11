using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class SortedListDemo
    {

        static void Main()
        {
            SortedList S = new SortedList();
            S.Add("22SOECE11172", "Ankit");
            S.Add("22SOECE11170", "Raj");
            S.Add("22SOECE11190", "Sheilendra");
            S["22SOECE11170"] = "Anku";

            for (int i = 0; i < S.Count; i++)
                Console.WriteLine(S.GetByIndex(i));
            Console.ReadKey();
        }
    }
}
