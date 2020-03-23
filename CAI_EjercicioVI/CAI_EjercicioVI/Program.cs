using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioVI
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine("El número más bajo es: " + numeros [0]);

            Console.WriteLine("El número más alto es: " + numeros[4]);

            Console.WriteLine("El número del medio es: " + numeros[2]);

            Console.ReadKey(true);
        }
        
    }
}
