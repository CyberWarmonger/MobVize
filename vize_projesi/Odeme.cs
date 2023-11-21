using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_projesi
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        public Odeme(List<string> veriler)
        {
            InitializeComponent();
            foreach (string veri in veriler)
            {
                listBox1.Items.Add(veri);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = Form1.toplam.ToString();
            listBox2.Items.Add($"Masa 1'in ücreti = {Form1.toplamFiyat1}");
            listBox2.Items.Add($"Masa 2'in ücreti = {Form1.toplamFiyat2}");
            listBox2.Items.Add($"Masa 3'in ücreti = {Form1.toplamFiyat3}");
            listBox2.Items.Add($"Masa 4'in ücreti = {Form1.toplamFiyat4}");
            listBox2.Items.Add($"Masa 5'in ücreti = {Form1.toplamFiyat5}");
            DateTime suankiZaman = DateTime.Now;
            string tarih = suankiZaman.ToShortDateString();
            string saat = suankiZaman.ToShortTimeString();

            label3.Text = "Odeme alinan tarih" + tarih + " - " + saat;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
