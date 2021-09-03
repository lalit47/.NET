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
        private int EmpNo;
        private decimal Basic;
        private short DeptNo;


        private static int lastEmpNo=0;
        public Employee()
        {
        
            
         }
        public Employee(String Name="NoName",decimal Basic=12000, short DeptNo=15)
        {
            this.Name = Name;
            this.EmpNo = ++lastEmpNo;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }


        public String Ename
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
        public int Empno
        {

            get { return EmpNo; }

        }
        public short Dept
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
        //public decimal Salary
        //{
        //    set
        //    {
        //        if (value > 0 && value < 15000)
        //        {
        //            Basic= value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input");
        //        }
        //    }
        //    get
        //    {
        //        return Basic;
        //    }
        //}





        private decimal HRA;
        private decimal DA;

        public decimal GetNetSalary()
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

            return Basic + HRA + DA;
        }

        //public void SetNetSalary(decimal Basic)
        //{
        //    if (Basic < 10000)
        //    {

        //        HRA = Basic * 1 / 10;
        //        DA = Basic * 9 / 10;


        //    }
        //    else
        //    {

        //        HRA = 2000;
        //        DA = (Basic * 9 / 10);

        //    }




        //}

        
        //public decimal GetNetSalary()
        //{
            
        //    return Basic + HRA + DA;
        //}
        static void Main(string[] args)

        {
            Employee o1 = new Employee("Amol",10000, 10);
            Employee o2 = new Employee("Amit", 123465);
            Employee o3 = new Employee("Ashish");
            Employee o4 = new Employee();


            // o1.SetNetSalary(10000);
            // Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();
            Console.WriteLine(o1.Empno + " | " + o1.Ename + " | " + o1.Dept + " | " + o1.GetNetSalary());
            Console.WriteLine(o2.Empno + " | " + o2.Ename + " | " + o2.Dept + " | " + o2.GetNetSalary());
            Console.WriteLine(o3.Empno + " | " + o3.Ename + " | " + o3.Dept + " | " + o3.GetNetSalary());
            Console.WriteLine(o4.Empno + " | " + o4.Ename + " | " + o4.Dept + " | " + o4.GetNetSalary());
            Console.WriteLine("=================================================");
            Console.WriteLine(o4.Empno + " | " + o4.Ename + " | " + o4.Dept + " | " + o4.GetNetSalary());
            Console.WriteLine(o3.Empno + " | " + o3.Ename + " | " + o3.Dept + " | " + o3.GetNetSalary());
            Console.WriteLine(o2.Empno + " | " + o2.Ename + " | " + o2.Dept + " | " + o2.GetNetSalary());
            Console.WriteLine(o1.Empno + " | " + o1.Ename + " | " + o1.Dept + " | " + o1.GetNetSalary());


            Console.ReadLine();

        }

    
    }
}
