using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Magazyn
    {
        private string nazwa = "Sklepowy";
        private int pojemność = 1000000;
        protected bool czyDostepny = true;
        static bool otwarty = true;
        public List<Regał> RegalList = new List<Regał>();

        public void ZmienNazwe()
        {

        }
        public void ZmienPojemnosc()
        {

        }
    }
}
