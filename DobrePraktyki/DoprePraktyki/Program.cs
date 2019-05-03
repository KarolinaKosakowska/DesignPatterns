using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoprePraktyki
{
    class Program
    {
        static void Main(string[] args)
        {
            var dzielenie = new NumberDivider();          
            Console.WriteLine( dzielenie.DoThis(10,2));
            Console.Read();
        }
    }
}
