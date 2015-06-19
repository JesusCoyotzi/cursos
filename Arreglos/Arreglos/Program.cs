using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void printVector(int[] a)
        {
            Console.Write("[ ");
            foreach (int f in a)
            {
                Console.Write(" {0} ", f);
            }

            Console.WriteLine(" ]");
        }
        
        static void Main(string[] args)
        {
            int[] j = new int[4];
            j[0] = 1;
            j[1] = 46;
            j[2] = 7;
            j[3] = 15;
            // j[4] = 12; Fuera de rango

            int[] w = { 1, 45, 25, 23 };
            int[] o = { 1, 2, 3 };

            Console.WriteLine("Programa de arreglos");
            Console.WriteLine(j[2]);
            Console.WriteLine(w[2]);

            Console.Write("[ ");
            for (int i = 0; i < j.Length; i++)
            {
                Console.Write(" {0} ", j[i]);

            }

            Console.WriteLine(" ]");

            printVector(w);
            printVector(j);
            printVector(o);

            Console.Read();
        }


    }
}
