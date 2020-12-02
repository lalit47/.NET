using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager("Lalit",12000,20);
            Console.WriteLine("EmpNo" + " " + "Ename" + " " + "NetSalary" + " " + "Dept" + " " + "Designation");
            Console.WriteLine(mg.Empno +" "+ mg.Ename + " " + mg.CalcNetSalary() + " "+mg.Dept + " " + mg.Designations);
            Console.WriteLine("==========================================");
            GeneralManager gm = new GeneralManager("Lalit", 12000, 20,"GM");
            Console.WriteLine("EmpNo" + " " + "Ename" + " " + "NetSalary" + " " + "Dept" + " " + "Designation" +" " +"perks");
            Console.WriteLine(gm.Empno + " " + gm.Ename + " " + gm.CalcNetSalary() + " " + gm.Dept + " " + gm.Designations + " "+ gm.Perk);
            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        protected String Name;
        protected int EmpNo;
        protected decimal Basic;
        protected short DeptNo;
        protected decimal HRA;
        protected decimal DA;


        private static int lastEmpNo = 0;
        public Employee()
        {


        }
        public Employee(String Name = "NoName", decimal Basic = 12000, short DeptNo = 15)
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
                if (value == "")
                {
                    Console.WriteLine("Name cannot be blank");
                    Console.ReadLine();
                }
                else
                {
                    Name = value;
                }

            }
            get
            {
                return Name;
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

        public abstract decimal CalcNetSalary();

    }

    public class CEO : Employee
    {
        public CEO()
        {

        }
        public CEO(String Name = "NoName", decimal Basic = 12000, short DeptNo = 15, decimal HRA = 1200, decimal DA = 2100) : base(Name, Basic, DeptNo)
        {
            this.HRA = HRA;
            this.DA = DA;

        }

        public sealed override decimal CalcNetSalary()
        {
            if (Basic < 15000)
            {
                HRA = Basic * 2 / 10;
                DA = Basic * 9 / 10;
            }
            else
            {
                HRA = 4000;
                DA = (Basic * 9 / 10);
            }

            return Basic + HRA + DA;
        }
    }
    public class Manager : Employee
    {
        private string Designation;

        public Manager()
        {

        }

        public Manager(String Name = "NoName", decimal Basic = 12000, short DeptNo = 15, string Designation = "manager", decimal HRA = 1200, decimal DA = 2100) : base(Name, Basic, DeptNo)
        {
            this.Designation = Designation;
            this.HRA = HRA;
            this.DA = DA;
        }
        public String Designations
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Designation cannot be blank");
                    Console.ReadLine();
                }
                else
                {
                    Designation = value;
                }

            }
            get
            {
                return Designation;
            }

        }



        public override decimal CalcNetSalary()
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
    }
    public class GeneralManager : Manager
    {
        protected String perks;
        public GeneralManager()
        {

        }
        public GeneralManager(String Name = "NoName", decimal Basic = 12000, short DeptNo = 15, string Designation = "manager", decimal HRA = 1200, decimal DA = 2100, string perks = "one lakh") : base(Name, Basic, DeptNo)
        {
            this.perks = perks;
        }
        public String Perk
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Perks cannot be blank");
                    Console.ReadLine();
                }
                else
                {
                    perks = value;
                }

            }
            get
            {
                return perks;
            }

        }

    }

  
}

