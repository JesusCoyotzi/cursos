using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingresa el valor de inicio");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el valor final");
            b=Convert.ToInt32(Console.ReadLine());

            for ( int i=a; i < b; i++ )
            {
                Console.Write("{0} , ", i);
            }

            Console.ReadLine();
        }
    }
}
