using System;

namespace PareshSir
{
    abstract class Math
    {
        public abstract int add(int x, int y);

        public void Display()
        {
            Console.WriteLine("Display from Math");
        }
    }

    class Calculate : Math
    {
        public override int add(int x, int y)
        {
            return x + y;
        }
    }

    class Test
    {
        // You can add functionality to this class later if needed
    }

    class AbstractDemo // Renamed class Abstract to Program
    {
        static void Main(string[] args)  // This is the entry point of the program
        {
            // Create object of Calculate class
            Calculate obj1 = new Calculate();
            int r1 = obj1.add(10, 20);
            Console.WriteLine("Result of add: " + r1); // Print result

            // Create object of Test class
            Test obj2 = new Test();

            // Call the Display method from Math class
            obj1.Display();
        }
    }
}