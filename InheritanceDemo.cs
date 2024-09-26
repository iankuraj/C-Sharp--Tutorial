using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    class A
    {
        protected int x;
        public A(int x)
        {
            this.x = x;
        }
        public virtual void Display()
        {
            Console.WriteLine(x);
        }
    }

    //Data members from class A : 1
    //Data members from class B : 1
    //Data members from class C : 1
    //Total data Members are 3

    class B : A //Inherited the B properties of A
    {
        protected int y;

        public B(int x, int y) : base(x)
        {
            this.y = y;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(y);
        }

        class C : B //Inherited the C properties of B
        {
            protected int z;

            public C(int x, int y, int z) : base(x, y)
            {
                this.z = z;
            }

            public void GetData(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine(z);
            }

            internal class InheritanceDemo // Now `Main` is in a separate class
            {
                static void Main()
                {
                    C obj = new C(100, 200, 300);
                    obj.GetData(10, 20, 30);
                    obj.Display();
                }
            }
        }
    }

}

