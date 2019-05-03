using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wytwórnia Toyoty");
            Director director = new Director(new Avensis());
            director.Construct();
            director.GetBuildedParts();
            director = new Director(new Corolla());
            director.Construct();
            director.GetBuildedParts();
            //wynik
            //Wytwórnia Toyoty
            //Podwozie Avensis Silnik Avensis Nadwozie Avensis
            //Podwozie Corolla Silnik Corolla Nadwozie Corolla
            Console.Read();
        }
    }
}
