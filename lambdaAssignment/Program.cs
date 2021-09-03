using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignment
{
    class Employee
    {
        private decimal Basic;
        Employee e = new Employee();
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> o1 = (x, y, z) => x * y * z;
            Console.WriteLine(o1(10, 20, 30));
            Func<int, int, bool> o2 = (a, b) => (a > b);
            Func<Employee, decimal> o3 = (e) => e.Basic;
            Predicate<int> o4 = x => x % 2 == 0;
            Predicate<Employee> o5 = (e) => e.Basic > 10000;
        }
        static decimal SimpleInterest(decimal P, decimal N, decimal R)
        {
            return P * N * R;
        }


        static bool IsGreater(int a, int b)
        {
            return a > b;
        }
        decimal GetBasic(Employee e)
        {
            return e.Basic;
        }
        bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        bool IsGreaterThan10000(Employee e)
        {
            return Basic > 10000;
        }
    }
}