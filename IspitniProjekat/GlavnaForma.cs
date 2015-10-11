using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace IspitniProjekat
{
    public partial class GlavnaForma : MetroForm
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlavnaForma());
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
        }

        /*private void metroButton2_Click(object sender, EventArgs e)
        {
	        uiStyleManager.Style = ((MetroButton) sender).Style;
        }
        */
    }
}
