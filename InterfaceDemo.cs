using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    interface IMath1
    {
        int add(int x, int y);
        int sub(int x, int y);
    }
    interface IMath2
    {
        int mul(int x, int y);
    }
    interface IMath : IMath1 , IMath2
    {
        int div(int x, int y);
    }
    class Calculate : IMath1, IMath2 //Multiple Inheritance
    {
        public int add(int x, int y)
        {
            return (x + y);
        }
        public int sub(int x, int y) 
        {
            return (x - y);
        }
        public int mul(int x, int y)
        {
            return (x * y);
        }
        public int div(int x, int y)
        {
            return (x / y);
        }
    }
    class InterfaceDemo
    {
        static void Main()
        {
            Calculate obj1 = new Calculate();
            int r1 = obj1.add(10, 20);
            Console.WriteLine("Add: " + r1);

            int r2 = obj1.sub(10, 20);
            Console.WriteLine("sub: " + r2);

            int r3 = obj1.mul(10, 20);
            Console.WriteLine("Mul: " + r3);

            int r4 = obj1.div(10, 2);
            Console.WriteLine("Div: " + r4);
        }
    }
}
