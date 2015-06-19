using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace lector
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Entrada a archivos");
            try
            {
                string msg;

                FileStream Fs = new FileStream("prueba3.txt", FileMode.Open, FileAccess.ReadWrite);
                StreamReader Sr = new StreamReader(Fs);
                msg = Sr.ReadLine();


                Console.WriteLine(msg);
                Sr.Close();
                Fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
