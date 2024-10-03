using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    internal class DelegateDemo2
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
            MyDelegate obj1 = new MyDelegate(Add); //2_Instatiation
            MyDelegate obj2 = new MyDelegate(Sub); //2_Instatiation
            MyDelegate obj3 = new MyDelegate(Mul); //2_Instatiation
            MyDelegate obj4 = new MyDelegate(Div); //2_Instatiation

            obj1(20, 10); //3_invocation or Calling an Add Method
            obj2(20, 10); //3_invocation or Calling an Sub Method
            obj3(20, 10); //3_invocation or Calling an Mul Method
            obj4(20, 10); //3_invocation or Calling an Div Method
        }
    }
}
