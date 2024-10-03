using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class DelegateDemo3 //MultiCast Delegate
    {
        //1_Declaration
        delegate void MyDelegate(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            MyDelegate obj = new MyDelegate(Add); //2_Instatiation
            obj += new MyDelegate(Sub); //2_Instatiation
            obj += new MyDelegate(Mul); //2_Instatiation
            obj += new MyDelegate(Div); //2_Instatiation

            obj(20, 10); //3_invocation or Calling an Add,Sub,Mul and Div Methods
        }
    }
}
