using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        //Ejercicio que muestre si cada número que se teclea es positivo o negativo
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número (presiona 0 para salir): ");

            while (true)
            {
                Console.Write("Ingresa un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Hasta luego!");
                    break;
                }
                else if (numero > 0)
                {
                    Console.WriteLine("El numero es positivo.");
                }
                else
                {
                    Console.WriteLine("El numero es negativo.");
                }
        }
    }
}
}

