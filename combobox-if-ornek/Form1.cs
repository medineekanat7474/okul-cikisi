using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_if_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbgünler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks=cbgünler.SelectedIndex;

            if(indeks>=0&& indeks <= 2)
            {
                lblDurum.Text = "çıkış saati: 16:40";
            }
            else if(indeks>=3&& indeks <= 4)
            {
                lblDurum.Text = "çıkış saati: 15:50";
            }
            else
            {
                lblDurum.Text = "tatil günü:))";
            }
        }
    }
}
