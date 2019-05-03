using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Wozek : IWozek    
    {
        public string nazwa;
        private readonly Kierowca kierowca;

        public Wozek(Kierowca kierowca)
        {
            this.kierowca = kierowca;
        }
        public Wozek()
        {

        }

        public void Jedz()
        {

        }
        public void Hamuj()
        {

        }

    }
}
