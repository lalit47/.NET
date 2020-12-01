using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employee
    {
        private String Name;
        private int EmpNo=0;
        private decimal Basic;
        private short DeptNo;
        public Employee()
        {
            EmpNo++; 
            Console.WriteLine(EmpNo);
           
        }
        public Employee(String Name,decimal Basic, short DeptNo)
        {
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public Employee(String Name, decimal Basic)
        {

            this.Name = Name;
            this.Basic = Basic;

        }
        public Employee(String Name)
        {

            this.Name = Name;
          

        }


        public String P1
        {
            set
            {
                if (value=="")
                {
                    Console.WriteLine("Name cannot be blank");
                    Console.ReadLine();
                }
                else
                {
                    Name = value;
                }

            }
                get{
                    return  Name;
                    }

        }
        public int P2
        {
          
            get
            {
                return EmpNo;
            }

        }
        public short P4
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            get
            {
                return DeptNo;
            }
        }


        


        private decimal HRA;
        private decimal DA;

        public void SetNetSalary(decimal Basic)
        {
            if (Basic < 10000)
            {

                HRA = Basic * 1 / 10;
                DA = Basic * 9 / 10;


            }
            else
            {

                HRA = 2000;
                DA = (Basic * 9 / 10);

            }




        }

        
        public decimal GetNetSalary()
        {
            
            return Basic + HRA + DA;
        }
        static void Main(string[] args)

        {
           Employee e1 = new Employee("Lalit", 1000, 20);
           Employee e2 = new Employee("Amit", 12000, 15);
           Employee e3 = new Employee("Amol", 123465);
           Employee e4 = new Employee("Amol");
           Employee e5 = new Employee();
            Console.WriteLine(e1.P1);
            Console.WriteLine(e1.EmpNo);
            e1.SetNetSalary(e1.Basic); 
            Console.WriteLine(e1.GetNetSalary());
            Console.WriteLine(e1.P4);

            Console.WriteLine(e2.P1);
            Console.WriteLine(e2.P2);
            e2.SetNetSalary(e2.Basic); ;
            Console.WriteLine(e2.GetNetSalary());
            Console.WriteLine(e2.P4);

            Console.WriteLine(e3.P1);
            Console.WriteLine(e3.P2);
            e3.SetNetSalary(e3.Basic);
            Console.WriteLine(e3.GetNetSalary());
            Console.WriteLine(e3.P4);
            Console.ReadLine();

        }

    
    }
}
