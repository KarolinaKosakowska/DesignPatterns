using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Półka
    {
        public string nazwa;
       

        public Półka()
        {

        }
        public Półka(Regał regał)
        {
            regał.półki.Add(this);

        }
    }
}
