using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Budynek
    {
        public string nazwa;
        private string przeznaczenie;
        private DateTime rokProdukcji;
        public List<Piętro> piętra = new List<Piętro>();
       
        public Budynek(Piętro piętro)
        {
            this.piętra.Add(piętro);
        }
       
        public class Piętro
        {
            public string nazwa;
            public int numer;

           
        }
       
        


    }
}
