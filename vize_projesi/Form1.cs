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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Su", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Tost", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Çiğ Köfte", 25.0m);
            urunFiyatlari.Add("Trileçe", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Su", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Tost", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Çiğ Köfte", 0);
            urunAdetleri.Add("Trileçe", 0);
            urunAdetleri.Add("Künefe", 0);

            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxSu.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu.Text);
                toplamFiyat += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
            }

            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxTost.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost.Text);
                toplamFiyat += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
            }
            if (checkBoxIskender.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxCigKofte.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte.Text);
                toplamFiyat += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
            }
            if (checkBoxTrilece.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece.Text);
                toplamFiyat += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
            }
            if (checkBoxKunefe.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
            label1.Text = $"Toplam Fiyat: {toplamFiyat} TL";
            foreach (var urun in urunAdetleri)
            {
                listBox1.Items.Add($"{urun.Key}: {urun.Value} adet");
            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Su", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Tost", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Çiğ Köfte", 25.0m);
            urunFiyatlari.Add("Trileçe", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Su", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Tost", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Çiğ Köfte", 0);
            urunAdetleri.Add("Trileçe", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola2.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxSu2.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu2.Text);
                toplamFiyat += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
            }

            if (checkBoxFanta2.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta2.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay2.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay2.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxTost2.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost2.Text);
                toplamFiyat += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
            }
            if (checkBoxIskender2.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender2.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner2.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner2.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxCigKofte2.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte2.Text);
                toplamFiyat += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
            }
            if (checkBoxTrilece2.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece2.Text);
                toplamFiyat += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
            }
            if (checkBoxKunefe2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe2.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ürünlerin fiyatlarini tutacak dictionary
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Su", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Tost", 25.0m);
            urunFiyatlari.Add("İskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Çiğ Köfte", 25.0m);
            urunFiyatlari.Add("Trileçe", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);


            // Ürünlerin adetlerini tutacak dictionary
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Su", 0);
            urunAdetleri.Add("Fanta", 0);
            urunAdetleri.Add("Çay", 0);
            urunAdetleri.Add("Tost", 0);
            urunAdetleri.Add("İskender", 0);
            urunAdetleri.Add("Döner", 0);
            urunAdetleri.Add("Çiğ Köfte", 0);
            urunAdetleri.Add("Trileçe", 0);
            urunAdetleri.Add("Künefe", 0);


            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için degisken
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola3.Text);
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxSu3.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu3.Text);
                toplamFiyat += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
            }

            if (checkBoxFanta3.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta3.Text);
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay3.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay3.Text);
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxTost3.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost3.Text);
                toplamFiyat += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
            }
            if (checkBoxIskender3.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender3.Text);
                toplamFiyat += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
            }
            if (checkBoxDoner3.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner3.Text);
                toplamFiyat += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
            }
            if (checkBoxCigKofte3.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte3.Text);
                toplamFiyat += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
            }
            if (checkBoxTrilece3.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece3.Text);
                toplamFiyat += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
            }
            if (checkBoxKunefe3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe3.Text);
                toplamFiyat += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
            }
        }
    }
}
