using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double sal = double.Parse(Console.ReadLine());
            double salario = h * sal;

            Console.WriteLine("NUMBER = "+num);
            Console.WriteLine("SALARY = "+salario);
        }
    }
}