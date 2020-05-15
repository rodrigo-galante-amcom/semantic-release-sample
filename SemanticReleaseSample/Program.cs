using System;

namespace SemanticReleaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Semantic Release versioning!");
            Calculadora calc = new Calculadora();
            Console.WriteLine("Resultado da soma: " + calc.Somar(10, 15));
            Console.ReadKey();
        }
    }
}
