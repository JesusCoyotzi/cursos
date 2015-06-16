using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
           // string saludo;
            int i, j;
            float f;
            double d= 10.5;
            bool b;
            short s;
             //Console.WriteLine("Hola, Ingresa un saludo por favor");
            /*
            saludo=Console.ReadLine();
            Console.WriteLine(saludo);
            */
            Console.WriteLine("Hola, Ingresa un numero por favor");
            i =Convert.ToInt32( Console.ReadLine());
             f= Convert.ToSingle(Console.ReadLine());
           s = Convert.ToInt16(Console.ReadLine());
             i=(int)d;
            Console.WriteLine("Ingresaste {0}, {1}, {2} ", i,f,s);
            Console.WriteLine("El valor de double es {0} cateado a int es {1}", d, i);
             Console.Read();
            
        }
    }
}
