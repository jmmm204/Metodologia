using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosEjemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int suma = 0;
            Console.WriteLine("Programa usando arreglos bidimensionales.");
            Console.WriteLine("Digita los datos del arreglo:");

            //Llenando el arreglo
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                    suma += tabla1[f, c];
                }
            }
            // Imprimir el arreglo bidimensional
            Console.WriteLine("Imprimiendo el arreglo... ");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(" " + tabla1[f, c]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("La suma total de los elementos del arreglo es: " + suma);
            Console.ReadKey();
        }
    }
}