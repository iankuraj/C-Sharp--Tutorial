using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareshSir
{
    class Student
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string getfirstname() // geter method 
        {
            return firstname;
        }
        public void setFirstName(string firstname) //setter method 
        {
            this.firstname = firstname;
        }
    }
    internal class PropertyDemo
    {
        static void Main()
        {
            Student obj = new Student();
            // obj.firstname ="Ankit";
            obj.setFirstName("Ankit");
            //or 
            obj.FirstName = "Ankit";

            // console.Writeline(obj.firstname);
            // or
            Console.WriteLine(obj.FirstName);
            Console.WriteLine(obj.getfirstname());





        }
    }

}