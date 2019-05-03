using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterpreterNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cultureString = Console.ReadLine();
            string cultureString = "";
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.P:
                    cultureString = "Pl";
                    break;
                case ConsoleKey.E:
                    cultureString= "En";
                    break;
                default:
                    Console.WriteLine("Nieznany język");              
                    Console.Read();
                    return;
            }
            //Thread.CurrentThread.CurrentCulture = cultureInfo;
          
            Resources.Culture = cultureInfo;
            Console.WriteLine(Resources.name);
            Console.WriteLine(Resources.lastName);
            Console.Read();
        }
    }
}
