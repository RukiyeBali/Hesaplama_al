using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 birimfiyat, adet, toplamtutar;
            birimfiyat=Convert.ToInt32(txtBirimfiyat.Text);
            adet=Convert.ToInt32(txtAdet.Text);
            toplamtutar = birimfiyat * adet;
            lblToplamtutar.Text = "Toplam Tutar:  ₺"+toplamtutar.ToString();

        }
    }
}
