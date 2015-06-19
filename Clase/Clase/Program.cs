using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static double safeDivision(double x, double y)
        {
            
            try
            {
                double w;
                w = x / y;
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                if (x == 0)
                {
                    throw new ApplicationException("El valor del numerador es 0");
                }
                Console.WriteLine("{0} / {1} = {2}", x, y, w);
                return w;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("La división entre 0 no esta definida");
                return 0;
            }
            catch(ApplicationException e){
                Console.WriteLine(e.Message);
                return 0;

            }
            finally
            {
                Console.WriteLine("Error aritmético");
            }

            
        }

        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Programa de excepciones");
            Console.WriteLine("Ingresa 2 numeros");
            a=double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            safeDivision(a, b);
            Console.ReadLine();
        }
    }
}
