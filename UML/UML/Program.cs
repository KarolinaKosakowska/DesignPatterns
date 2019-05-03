using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Budynek.Piętro> pietra = new List<Budynek.Piętro>
            {
            new Budynek.Piętro
            {
                nazwa = "Piwnica",
                numer = -1
            },
            new Budynek.Piętro{
                nazwa = "Parter",
                numer = 0
            },
            new Budynek.Piętro
            {
                nazwa = "Drugie",
                numer = 2
            }
        };
        

    }
}
}
