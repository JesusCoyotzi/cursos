using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, total=0,j;
            Console.WriteLine("Ingresa un numero");
            num = int.Parse(Console.ReadLine());
            j = num;
            while (num <= 100)
            {
                Console.Write("{0} ", num);
                num++;
            }

            Console.WriteLine();

            num = j;

            do
            {
                total = total + num;
                num = num - 1;

            } while (num >0);

            Console.WriteLine("La suma de 0 a {0} es de {1}", j, total );

            Console.ReadLine();
        }
    }
}
