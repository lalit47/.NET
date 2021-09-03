using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Program1 p;
            p = new Program1();
            p.display();
            Console.WriteLine(p.Add(10,20,30));
            Console.WriteLine(p.Add(20, 50));
            Console.WriteLine(p.Add(c: 80));
            Console.ReadLine();
         
        }
    }

    public class Program1
    {
        public void display()
        {
            Console.WriteLine("This is my first program");
        }
        public int Add(int a=0, int b=0, int c=0)
        {
            return a + b + c;
        }
        public int Add(int a, int b)
        {
            return a + b ;
        }
        public int Add(int a)
        {
            return a;
        }
    }
    
}
