using Antywzorce.Spagetti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antywzorce
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zamawiam kawę; dużą 200ml; Z mlekiem; 50ml; Z cukrem; 2 kostki.");
            var coffee = new Drink().Create();
            Console.WriteLine(coffee);

            Console.Read();
            //Wynik:            
            //Kawa; duża 200 ml; z mlekiem 50 ml; z cukrem 2 kostki. 
        }
    }
}
