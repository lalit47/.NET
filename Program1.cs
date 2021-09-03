using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    
    class Employee
    {
        private String Name;
        private int EmpNo;
        private decimal Basic;
    

        public void SetData(int EmpNo, string Name, decimal Basic)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;
        }

        public void show()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(Name);
            Console.WriteLine(Basic);
        }

       

        public static void Main1(string[] args)
        {
            Console.WriteLine("No Of Employee = ");

            int capacity = int.Parse(Console.ReadLine());

            Employee[] e1 = new Employee[capacity];

            for (int i = 0; i < e1.Length; i++)
            {
                Console.WriteLine("Enter EmpNo = ");
                int EmpNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name = ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter salary = ");
                decimal Basic = decimal.Parse(Console.ReadLine());
                Employee temp = new Employee();
                temp.SetData(EmpNo,Name, Basic);
                e1[i] = temp;
            }

        
        decimal max = e1[0].Basic;
        Console.WriteLine("");
            Console.WriteLine("Highest Salary Employee");
            Console.WriteLine("");
            for (int i = 0; i<e1.Length; i++)
            {

                if (e1[i].Basic > max)
                {
                    decimal temp = max;
                    max = e1[i].Basic;
                    Console.WriteLine(max);
                    Console.ReadLine( );
                }
             }
Console.WriteLine("");
Console.WriteLine("\n Enter the EmpNo = ");
Console.WriteLine("");
int search = int.Parse(Console.ReadLine());

for (int i = 0; i < e1.Length; i++)
{

    if (e1[i].EmpNo == search)
    {
        e1[i].show();
    }

  }
        Console.ReadLine();
        }
    }
}

namespace MyNamespace
{
    struct Student
    {
        private string Name;
        private int RollNo;
        private decimal Marks;
        public void setvalues(int RollNo, string Name, decimal Marks)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Marks = Marks;
        }

        public void show()
        {
            Console.WriteLine(RollNo) ;
            Console.WriteLine(Name);
            Console.WriteLine(Marks);
        }
       


        public static void Main(string[] args)
        {

            int[,] arr = new int[5,3];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter marks for student RollNo-: {00} and SubjectId-: {01} ", i, j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("=====================================================");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Marks for student RollNo {00} and SubjectId {01} is {02}", i, j, arr[i, j]);
                }
                Console.WriteLine("=====================================================");
            }
            Console.ReadLine();
        }
        static void Main2(string[] args)

        {
            Console.WriteLine("Enter size");

            int[][] arr = new int[5][];
            for (int i = 0; i < arr.Length; i++)
            {
                int n = Convert.ToInt32(Console.Read());
                for (int j = 0; j < n; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                     arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();

        }
    }
  }


