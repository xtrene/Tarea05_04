using System;

namespace Tarea05_04
{
    class Program
    {

        static int factorial (int numero)
        {
            int resultado = numero;
            for (int i = numero-1; i > 0; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            int total = 0;
            Console.Write("Introduce número para calcular factorial: ");
            int num = Convert.ToInt32( Console.ReadLine());

            total = factorial(num);

            Console.WriteLine("el Factorial de {0} es: {1}", num, total);

            Console.ReadKey();

        }
    }
}
