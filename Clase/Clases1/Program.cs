using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa con clase");
            rect myRect= new rect();
            myRect.height = 12.5;
            myRect.width = 2.54;
            Console.WriteLine(myRect.area());

            rect miOtroRect = new rect();
            miOtroRect.height = 7.45;
            miOtroRect.width = 10.4;
            Console.WriteLine(miOtroRect.area());

            rect otroRect = new rect(12.5, 10);
            Console.WriteLine("El rectangulo de  {0} por {1} tiene un area de  {2}"
                , otroRect.height, otroRect.width, otroRect.area());

            Console.ReadLine();
         }
    }

    class rect
    {

        public double width{get;set;}

        public double height { get; set; }

        public rect()
        {

        }

        public rect(double x, double y)
        {
            this.height = y;
            this.width = x;
        }

        /*
        public void setHeight(double h){
            this.height = h;
        }

        public void setWidth(double w)
        {
            this.width = w;
        }*/

        public double area()
        {
            return width * height;
        }

    }
}
