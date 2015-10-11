using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IspitniProjekat
{
    public class Atribut
    {
        protected string ImeAtributa { get; set; }
        protected TipPodatka TipAtributa { get; set; }
        protected bool PrimarniKljuc { get; set; } = false;
        protected object Vrednost { get; set; } = null;
        protected string PrikazanoIme { get; set; }

        public Atribut(string ime, string prikazIme, object vrednost, TipPodatka tp, bool primarniKljuc)
        {
            ImeAtributa = ime;
            PrikazanoIme = prikazIme;
            Vrednost = vrednost;
            TipAtributa = tp;
            PrimarniKljuc = primarniKljuc;
        }

        public void PostaviVrednostAtributa(object vrednost)
        {
            Vrednost = vrednost;
        }

        public object VrednostAtributa => Vrednost;
        public TipPodatka TipPodatkaAtributa => TipAtributa;
        public string AsString() => Vrednost.ToString();

        public double AsDouble()
        {
            var vrednost = 0.0;
            double.TryParse(vrednost.ToString(), out vrednost);
            return vrednost;
        }

        public int AsInteger()
        {
            var vrednost = 0;
            int.TryParse(vrednost.ToString(), out vrednost);
            return vrednost;
        }
    }
    public enum TipPodatka
    {
        T_Integer = 0,
        T_Double,
        T_String
    }
}
