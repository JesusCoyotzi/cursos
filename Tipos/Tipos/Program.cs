using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            const int i=10,j=24,z=12;
            Console.WriteLine("Mi variable i vale {0}", i);
            Console.WriteLine("Un entero ocupa {0} bytes",sizeof(int));

            Console.WriteLine("i= {0} z= {2} j= {1}", i , j , z);

            Console.WriteLine("Un booleano ocupa {0} bytes", sizeof(bool));
            Console.WriteLine("Un short ocupa {0} bytes", sizeof(short));
            Console.WriteLine("Un long ocupa {0} bytes", sizeof(long));
            Console.WriteLine("Un float ocupa {0} bytes", sizeof(float));
            Console.WriteLine("Un double ocupa {0} bytes", sizeof(double));
            Console.WriteLine("Un decimal ocupa {0} bytes", sizeof(decimal));

            Console.Read();
        }
    }
}
