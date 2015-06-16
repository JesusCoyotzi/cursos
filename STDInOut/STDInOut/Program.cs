using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDInOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic In Out
            /*string alg;
            Console.WriteLine("Hola escribe algo");
            alg=Console.ReadLine();
            Console.WriteLine(alg);
            Console.Read();*/


 
            int i;
            float f;
            double d;
            short s;
            long l;
            char c;

               

            Console.WriteLine("Hola escribe un entero");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora escribe un flotante");
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ahora escribe un double");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora escribe un entero corto");
            s = Convert.ToInt16 (Console.ReadLine());
             Console.WriteLine("Ahora escribe un entero largo");
            l = Convert.ToInt64 (Console.ReadLine());
            Console.WriteLine("Ahora escribe un caracter");
            c=Convert.ToChar(Console.ReadLine());

            //Var types
            Console.WriteLine("El tamaño de int i {0}  es de : {1}", i , sizeof(int));
            Console.WriteLine("El tamaño de float f {0}  es de : {1}", f , sizeof(float));
            Console.WriteLine("El tamaño de double de {0}  es de : {1}", d , sizeof(double));
            Console.WriteLine("El tamaño de short s {0}  es de : {1}", s , sizeof(short));
            Console.WriteLine("El tamaño de long l {0}  es de : {1}", l , sizeof(long));
             
            Console.WriteLine("El tamaño de char  c {0}  es de : {1}", c , sizeof(char));
            Console.Read(); 
          
                
        }
    }
}
