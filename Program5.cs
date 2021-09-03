using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "!!!!");
            Console.WriteLine("Enter your roll:");
            int roll=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your marks:");
            int marks=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("===========================");
            Console.WriteLine("STUDENT DETAILs");
            Console.WriteLine("===========================");
            Console.WriteLine("name    " + name);
            Console.WriteLine("===========================");
            Console.WriteLine("roll    " + roll);
            Console.WriteLine("===========================");
            Console.WriteLine("marks   " + marks);
            Console.WriteLine("===========================");
            Console.ReadLine();
        }
    }
}
