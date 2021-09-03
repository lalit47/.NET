using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseofProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.set(42);
            //Console.WriteLine(p.get());
            Program p = new Program();
            Console.WriteLine(p.P1 = 52);
            Console.WriteLine("================");
            Console.WriteLine(p.p2 = 38);
            Console.WriteLine("================");
            Console.WriteLine(p.p3);
            Console.WriteLine(p.p4);
            Console.ReadLine();
        }

        //private int i;
        //public void set(int x)
        //{
        //    if (x <= 50)
        //        i = x;
        //    else
        //        Console.WriteLine("no greater than 50");
        //}
        //public int get()
        //{
        //    return i;
        //}

        //variable
        private int p1;
        //property datatype is assigned to set
        //it is used for validating code
        public int P1
        {
            set
            {
                if (value <= 50)
                {
                    p1 = value;
                }
                else
                {
                    Console.WriteLine(value + " is greater than 50");
                }

            }
            get
            {
                return p1;
            }

        }
        private int p2;
        //named property
        public int P2
        {
            set { p2 = value; }
            get { return p2; }
        }
        //read only property
        private int p3 = 500;

        public int P3
        {
            get { return p3; }
        }
    
        private String p4 = "Hello";
           public String P4
        {
              get { return p4; }

        }
      
    }





}