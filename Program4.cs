using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    public class Program
    {
        public void Main1(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
        static void Main()
        {
            Program1 p = new Program1();
            p.Display();
           Console.WriteLine( p.Add(10, 20, 30));
           Console.WriteLine( p.Substract(30, 10, 5));
           Console.WriteLine( p.Multiply(5, 2, 3));
           Console.WriteLine(p.Divide(8, 2));
           Console.ReadLine();
        }
    }

    class Program1
    {
        public void Display()
        {

            Console.WriteLine("This is my first program");
            Console.WriteLine("to calculate numbers:");


        }
        public int Add(int a,int b,int c)
        {
            return a * b * c;

        }
        public int Substract(int a, int b, int c)
        {
            return a * b * c;

        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;

        }
        public int Divide(int a, int b)
        {
            return a / b ;

        }
    }





}
