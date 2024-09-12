using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] frecuencias = new int[13];
            int numeroDeTiradas = 36000;

            for (int i = 0; i < numeroDeTiradas; i++)
            {
                int dado1 = rand.Next(1,7);
                int dado2 = rand.Next(1, 7);
                int suma = dado1 + dado2;
                frecuencias[suma]++;
            }

            Console.WriteLine("Suma\tFrecuencia\tPorcentaje");
            Console.WriteLine("------------------------------------");

            for (int i = 2; i <= 12; i++)
            {
                double porcentaje = (frecuencias[i] / (double)numeroDeTiradas) * 100;
                Console.WriteLine($"{i}\t{frecuencias[i]}\t\t{porcentaje:F2}%");
            }

        }
    }
}
