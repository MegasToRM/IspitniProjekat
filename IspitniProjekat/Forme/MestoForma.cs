using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IspitniProjekat
{
    public partial class MestoForma : EntForma
    {
        public MestoForma()
        {
            InitializeComponent();
        }

        public override bool MozeSeSacuvati()
        {
            return true;
        }
    }
}
