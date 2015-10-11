using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspitniProjekat
{
    class ListaAtributa
    {
        List<Atribut> Atributi = new List<Atribut>();
        List<string> ImenaAtributa = new List<string>();

        public bool DodajAtribut(string ime, string prikazIme, object vrednost, TipPodatka tp, bool primarniKljuc)
        {
            var atribut = new Atribut(ime, prikazIme, vrednost, tp, primarniKljuc);
            if (ImenaAtributa.Contains(ime)) return false;

            Atributi.Add(atribut);
            ImenaAtributa.Add(ime);

            return true;
        }
    }
}
