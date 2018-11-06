using System;
using System.Globalization;

namespace SecondPerformance
{
    class Program
    {
        static void Main(string[] args) 
        {
            int N;
            double x, y, resultado;

            N = int.Parse(Console.ReadLine());

            for (int i=0; i<N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[1], CultureInfo.InvariantCulture);
                y = double.Parse(vet[2], CultureInfo.InvariantCulture);
                if(y == 0.0)
                {
                    Console.WriteLine("Não Existe");
                }
                else
                {
                    resultado = x / y;
                    Console.WriteLine(resultado);
                }
                Console.ReadLine();
            }
        }
    }
}
