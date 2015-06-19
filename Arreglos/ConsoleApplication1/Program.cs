using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Funciones
{
    class Program
    {
        static void setTitleBar(string txt)
        {
            string titulo = "";
            for (int i = 0; i < txt.Length; i++)
            {
                titulo = titulo + txt[i];
                Console.Title = titulo;
                Thread.Sleep(100); //DElay()
            }
        }

        static void sayHi()
        {
            Console.WriteLine("Hola");
        }

        static int suma(int a , int b)
        {
            int total = a + b;
            if(total>10)
                return total;
            return 0;
        }

        static void swapInt(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void plusFive(out float x, out float y)
        {
            x = 0;
            y = 1;
            x = x + 5;
            y = y + 5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Cambio de Barra de títulos");
            //string msg;
           /* msg = Console.ReadLine();
            setTitleBar(msg);*/

            int a = 2, b = 9;
            float x, y;
            Console.WriteLine("a contiene {0} y b contiene :{1}", a, b);
            swapInt(ref a, ref b);
            Console.WriteLine("a contiene {0} y b contiene :{1}", a, b);

            plusFive(out x,out y);
            Console.WriteLine("x contiene {0} y y contiene :{1}", x, y);

            sayHi();
            Console.WriteLine(suma(2, 3));

            Console.ReadKey();
        }
    }
}
