using System;
using System.Collections;

namespace PareshSir
{
    internal class ArrayListDemo
    {

        public static void Main()
        {
            //Creating an object of collection
            ArrayList obj = new ArrayList();

            //Adding elements into a cpllection
            obj.Add("RKU");
            obj.Add(125);
            obj.Add(152.85);
            obj.Add('X');
            obj.Add(true);

            //Fetching the no. of elements into collection
            Console.WriteLine("Number of Elements: " + obj.Count);

            //Removing an element by value from a collection
            obj.Remove("RKU");


            //Traversing a collection element by element
            foreach (object str in obj) //object
                Console.WriteLine(str + " ");
            Console.ReadKey();
        }
    }
}
