using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Kierowca
    {
        public string imie = "Jan";
        private bool czyPosiadaUprawnienia = true;
        private int iloscGodzinPracy;
        private readonly Wozek wozek;

        public Kierowca(Wozek wozek)
        {
            this.wozek = wozek;
        }
        public Kierowca()
        {

        }


        public void RozpocznijPrace(KartaPracy karta)
        {
            karta.RozpocznijPrace();

        }
        public void Pracuj()
        {

        }
        public void IdzNaPrzerwe()
        {

        }
        public void ZakończPrace(KartaPracy karta)
        {
            karta.ZakończPrace();

        }
    }
}
