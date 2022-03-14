using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio_Day1.Day1
{
    internal class Consoleintro
    {
        public static void MultiConsole()
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine("aaa \nyayaya"); // ~> \n = ganti baris
            Console.WriteLine("nyoba" + "belajar C#"); //concat


            //quote
            Console.WriteLine("i love programming \"C\"");

            //veerbatim
            Console.WriteLine(@"Bootcamp .net
with Code ID
Indonesia
            ");

            //formatting
            Console.WriteLine("Temperatur di jkt tgl {0} suhu {1} celcius", DateTime.Today, 32.0);
        }
    }
}
