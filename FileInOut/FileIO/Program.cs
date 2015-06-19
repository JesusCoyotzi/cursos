using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg;
            Console.WriteLine("Salida a archivos");
            msg=Console.ReadLine();
            FileStream Fs = new FileStream("prueba2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter Sw = new StreamWriter(Fs);
           /* for (int i=0; i < 10; i++)
            {
                Sw.Write(i);
            }*/

            Sw.WriteLine(msg);
            Sw.Close();
            Fs.Close();

            Console.Read();
        }
    }
}
