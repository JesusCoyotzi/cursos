using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesVars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos y Varibles");
            Console.WriteLine("El tamaño de byte es {0} byte", sizeof(sbyte));
            Console.WriteLine("El tamaño de int es {0} byte", sizeof(int));
            Console.WriteLine("El tamaño de short es {0} byte", sizeof(short));
            Console.WriteLine("El tamaño de int 64  es {0} byte", sizeof(Int64));
            Console.WriteLine("El tamaño de char es {0} byte", sizeof(char));
            Console.WriteLine("El tamaño de long es {0} byte", sizeof(long));
            Console.WriteLine("El tamaño de float es {0} byte", sizeof(float));
            Console.WriteLine("El tamaño de double es {0} byte", sizeof(double));
            Console.WriteLine("El tamaño de decimal es {0} byte", sizeof(decimal));
         
            Console.ReadLine();

        }
    }
}

