using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int contadorPar = 0, contadorImpar = 0;
            Console.WriteLine("Digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            { // Lectura
                Console.Write("Ingresa numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo: ");
            Console.WriteLine();
            for (int i = 0;i < 10; i++)
            { // Muestra en pantalla
                Console.Write(numeros[i] + ", ");
                if (numeros[i] % 2 == 0)
                {
                    contadorPar++;
                }
                else
                {
                    contadorImpar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de pares: " + contadorPar);
            Console.WriteLine("Cantidad de impares: " + contadorImpar);
            Console.ReadKey();
        }
    }
}
