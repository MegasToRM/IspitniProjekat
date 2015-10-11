using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IspitniProjekat
{
    public abstract partial class EntForma : MetroForm
    {
        public bool PodaciSacuvani = false;
        protected EntForma()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!MozeSeSacuvati())
            {
                return;
            }
            PodaciSacuvani = true;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public abstract bool MozeSeSacuvati();
    }
}
