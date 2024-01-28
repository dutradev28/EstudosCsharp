using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.WriteLine("Nome: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário " + func);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}