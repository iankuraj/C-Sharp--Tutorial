using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class DelegateDemo
    {
        delegate void MyDelegate(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Main()
        {
            MyDelegate obj1 = new MyDelegate(Add);

            obj1(20, 10); //It is method
        }
    }
}
