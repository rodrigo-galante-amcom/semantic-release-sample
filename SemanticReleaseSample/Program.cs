using System;

namespace SemanticReleaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Semantic Release versioning!");
            Calculadora calc = new Calculadora();
            Console.WriteLine("Valor1: " + 10);
            Console.WriteLine("Valor2: " + 6);
            Console.WriteLine("Resultado da soma: " + calc.Somar(10, 6));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Valor1: " + 10);
            Console.WriteLine("Valor2: " + 5);
            Console.WriteLine("Resultado da subtração: " + calc.Subtracao(10, 5));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Valor1: " + 10);
            Console.WriteLine("Valor2: " + 5);
            Console.WriteLine("Resultado da multiplicacao: " + calc.Multiplicar(10, 5));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Valor1: " + 20);
            Console.WriteLine("Valor2: " + 5);
            Console.WriteLine("Resultado da divisao: " + calc.Dividir(20, 5));
            Console.WriteLine("----------------------------------------");

            Console.ReadKey();
        }
    }
}
