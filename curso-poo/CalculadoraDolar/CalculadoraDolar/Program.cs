using System;
using System.Globalization;

namespace CalculadoraDolar {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pagao em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }



}
