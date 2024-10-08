using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.Write("World ");
            Console.Write("!!!");

            Console.WriteLine("Для выхода нажмите клавишу Enter");

            Console.ReadKey();
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                while (keyInfo.Key != ConsoleKey.Enter)
                    keyInfo = Console.ReadKey();
            }
        }
    }
}
