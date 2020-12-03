using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mg = new Manager("NoName", 100000, 15, "Manager");
            Console.WriteLine("EmpNo" + " " + "Ename" + " " + "Dept" + " " + "Designation" + " " + "Basic" + " " + "NetSalary");
            Console.WriteLine(mg.Empno + " | " + mg.Ename + " | " + mg.Dept + " | " + mg.Designations + " | " + mg.Basic + " | " + mg.CalcNetSalary(100000));
            Console.WriteLine("==========================================");
            GeneralManager gm = new GeneralManager("NoName");
            Console.WriteLine("EmpNo" + " " + "Ename" + " " + "Dept" + " " + "Designation" + " " + "Basic" + " " + "Perk" + " " + "NetSalary");
            Console.WriteLine(gm.Empno + " | " + gm.Ename + " | " + gm.Dept + " | " + gm.Designations + " | " + gm.Basic + " | " + gm.Perk + " | " + gm.CalcNetSalary(120000));
            Console.WriteLine("==========================================");
            CEO c = new CEO("NoName");
            Console.WriteLine("EmpNo" + " " + "Ename" + " " + "Dept" + " " + "Basic" + " " + "NetSalary");
            Console.WriteLine(c.Empno + " | " + c.Ename + " | " + c.Dept + " | " + c.Basic + " | " + c.CalcNetSalary(150000));
            Console.WriteLine("==========================================");
           

        }
    }
    public abstract class Employee : IDbFunctions
    {
        private String Name;
        private int EmpNo;
        protected decimal basic;
        private short DeptNo;

        public abstract decimal Basic
        {
            get;
            set;
        }

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

        public abstract decimal CalcNetSalary(decimal basic);

        public void Delete()
        {
            Console.WriteLine("Employee - IDb.Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Employee - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee - IDb.Update");
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        private decimal HRA;
        private decimal DA;

        public CEO()
        {

        }
        public CEO(String Name = "NoName", decimal Basic = 12000, short DeptNo = 15, decimal HRA = 1200, decimal DA = 2100) : base(Name, Basic, DeptNo)
        {
            this.HRA = HRA;
            this.DA = DA;

        }

        public override decimal Basic
        {
            set
            {
                if (value > 0 && value < 15000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            get
            {
                return basic;

            }
        }


        public sealed override decimal CalcNetSalary(decimal basic)
        {
            if (basic < 15000)
            {
                HRA = basic * 2 / 10;
                DA = basic * 9 / 10;
            }
            else
            {
                HRA = 4000;
                DA = (basic * 9 / 10);
            }

            return basic + HRA + DA;
        }
        public new void Delete()
        {
            Console.WriteLine("CEO - IDb.Delete");
        }

        public new void Insert()
        {
            Console.WriteLine("CEO - IDb.Insert");
        }

        public new void Update()
        {
            Console.WriteLine("CEO - IDb.Update");
        }

    }

    public class Manager : Employee, IDbFunctions
    {
        private string Designation;
        private decimal HRA;
        private decimal DA;

        public Manager()
        {

        }

        public Manager(String Name = "NoName", decimal basic = 12000, short DeptNo = 15, string Designation = "GManager", decimal HRA = 1200, decimal DA = 2100) : base(Name, basic, DeptNo)
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

        public override decimal Basic
        {
            set
            {
                if (value > 0 && value < 15000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            get
            {
                return basic;
            }
        }

        public override decimal CalcNetSalary(decimal basic)
        {
            if (basic < 10000)
            {
                HRA = basic * 1 / 10;
                DA = basic * 9 / 10;
            }
            else
            {
                HRA = 2000;
                DA = (basic * 9 / 10);
            }

            return basic + HRA + DA;
        }
        public new void Delete()
        {
            Console.WriteLine("Manager - IDb.Delete");
        }

        public new void Insert()
        {
            Console.WriteLine("Manager - IDb.Insert");
        }

        public new void Update()
        {
            Console.WriteLine("Manager - IDb.Update");
        }

    }
    public class GeneralManager : Manager, IDbFunctions
    {
        protected String perks;
        public GeneralManager()
        {

        }
        public GeneralManager(String Name = "NoName", decimal basic = 12000, short DeptNo = 15, string Designation = "GManager", decimal HRA = 1200, decimal DA = 2100, string perks = "one lakh") : base(Name, basic, DeptNo)
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
        public new void Delete()
        {
            Console.WriteLine("GManager - IDb.Delete");
        }

        public new void Insert()
        {
            Console.WriteLine("GManager - IDb.Insert");
        }

        public new void Update()
        {
            Console.WriteLine("GManager - IDb.Update");
        }
    
    }
         public interface IDbFunctions
        {
            void Insert();
            void Update();
            void Delete();
        }

    
}