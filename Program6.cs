using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBasics
{
    class Program
    {
        private int var;
        static void Main(string[] args)
        {

            
            Program p = new Program();
            Program.display();

            Program p1 = new Program(200);
            Console.WriteLine(p1.var);
            Console.ReadLine();
        }

        Program()
        {
            Console.WriteLine("NonPamaterised Cons.....");
        }
        Program(int x)
        {
            Console.WriteLine("Parameterised Cons.....");
            this.var = x;
           
        }
        static Program()
        {
            Console.WriteLine("Static Constructor");
        }

        public static void display()
        {
            Console.WriteLine("Static contructor is being called");
        }
    }
}
