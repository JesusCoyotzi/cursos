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
        static string msg;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu mensaje");
            msg = Console.ReadLine();
            writeMSG(msg);
            readMSG();
            Console.WriteLine(msg);
            Console.ReadKey();

        }

        static void writeReadByte()
        {
            try
            {
                FileStream Fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                for (int i = 40; i <= 61; i++)
                {
                    Fs.WriteByte((byte)i);
                }
                Fs.Position = 0;
                for (int i = 0; i <= 20; i++)
                {
                    Console.Write(Fs.ReadByte() + " ");
                }
                Fs.Close();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void writeMSG(string a)
        {
            try
            {
                FileStream Fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter Sw = new StreamWriter(Fs);
                Sw.WriteLine(a);
                Sw.Close();
                Fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        static void readMSG()
        {
            try
            {
                FileStream Fs = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader Sr = new StreamReader(Fs);
                msg = Sr.ReadLine();
                Sr.Close();
                Fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
