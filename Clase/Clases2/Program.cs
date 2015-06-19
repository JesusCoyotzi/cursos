using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases2
{
    class Program
    {
        static void Main(string[] args)
        {
            rect miRect = new rect(12.5,4);
            Console.WriteLine("Programa de herencia");
            Console.WriteLine(miRect.area());

            trian miTriangle = new trian(12.5,4);
            Console.WriteLine(miTriangle.area());


            Console.ReadLine();
        }


    }

    class poligono
    {
        protected double ancho, alto;
        
        public virtual double area()
        {
            return 0;
        }
    }

    class rect : poligono
    {
        public rect(double x, double y)
        {
            ancho = x;
            alto = y;
        }

        public override double area()
        {
            return ancho * alto;
        }

    }


    class trian : poligono
    {
        public trian(double x, double y)
        {
            ancho = x;
            alto = y;
        }

        public override double area()
        {
            return ancho * alto/2;
        }

    }

}
