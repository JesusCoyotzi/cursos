using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSeleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int color;
            bool salida=true;
            string cadena;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            while (salida)
            {
                Console.WriteLine("Ingresa un número para seleccionar un color");
                color = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa un mensage para desplegar");
                cadena = Console.ReadLine();
                switch (color)
                {
                    case 0:
                        salida=false;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        Console.WriteLine("Fuera del rango, no acepto ese color");
                        Console.WriteLine("0 para salir");
                        break;
                }

                Console.WriteLine(cadena);

                Console.Read();
            }
        }
    }
}
