using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticBasicConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Program1.SatiticFunc();
            Console.WriteLine(Program1.var=90);
            Program1 p = new Program1();
            p.NonStaticFunc();
            Console.WriteLine(p.i = 10);
            Console.ReadLine();
        }
    }

    public  class Program1
    {
       public static int var ;
         public  static void SatiticFunc()
        {
            Console.WriteLine("I am static function");
            Console.WriteLine("I can access static method and static field only....");


        }

        public int i;
        public void NonStaticFunc()
        {
           
            Console.WriteLine("I am non static function");
            Console.WriteLine("I can access nonstatic methods as well as static methods ");
            Console.WriteLine(var + ":  100");

        }


    }




}
