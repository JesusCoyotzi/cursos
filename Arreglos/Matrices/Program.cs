using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void printMat(double[,] a)
        {
            for (int y = 0; y < 3; y++)
            {
                Console.Write("| ");
                for (int x = 0; x < 2; x++)
                {
                    Console.Write("{0} ", a[x,y]);
                }
                Console.WriteLine("|");
            }
        }

        static void fillMat(double[,] b)
        {
            for (int y = 0; y < 4; y++)
            {
               for (int x = 0; x < 4; x++)
                {
                    b[x, y] = x + y;
                }
            }
        }

        static void Main(string[] args)
        {
            double[,] matriz = new double[4, 4];
            double[,] cuadro = { {2,3,4} ,{4,5,6}};

            Console.WriteLine("Arreglos Multidimensionales");

            fillMat(matriz);
            printMat(cuadro);

            Console.ReadKey();
        }
    }
}
