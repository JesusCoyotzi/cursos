using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Hola, Ingresa un numero, entero en 10 y 20");
            i=Convert.ToInt32(Console.ReadLine());

            if((i>=10)&&(i<=20))
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("EL número {0} esta dentro del rango", i);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("EL número esta fuera del intervarlo");
            }
     
            

           /* if (i < 10)
            {
                Console.WriteLine("El numero es menor a 10");
                Console.WriteLine("Tu numero {0}", i);

                if (i > 20)
                {
                    Console.WriteLine("El numero es mayor a 20");
                    Console.WriteLine("Tu numero {0}", i);
                }
                else
                {
                    Console.WriteLine("El número esta entre 20 y 10");
                }
            }*/
            Console.Read();
        }
    }
}
