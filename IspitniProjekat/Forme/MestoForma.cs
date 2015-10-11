using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IspitniProjekat.Klase;
using IspitniProjekat.Forme;

namespace IspitniProjekat.Forme
{
    public partial class MestoForma : EntForma, EntInterface
    {
        public MestoForma()
        {
            InitializeComponent();
        }
        public override void btnSacuvaj_Click(object sender, EventArgs e)
        {
            SacuvajPodatke();
        }

        public override void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void SacuvajPodatke()
        {
            MessageBox.Show(MozeSeSacuvati() ? "Moze se sacuvati!" : "Ne moze se sacuvati!");
        }

        public bool MozeSeSacuvati()
        {
            return true;
        }
    }
}
