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
            Dictionary<string, decimal> urunFiyatlari = new Dictionary<string, decimal>();
            urunFiyatlari.Add("Kola", 15.0m);
            urunFiyatlari.Add("Su", 5.0m);
            urunFiyatlari.Add("Fanta", 15.0m);
            urunFiyatlari.Add("Çay", 10.0m);
            urunFiyatlari.Add("Tost", 25.0m);
            urunFiyatlari.Add("iskender", 50.0m);
            urunFiyatlari.Add("Döner", 30.0m);
            urunFiyatlari.Add("Çiğ Köfte", 25.0m);
            urunFiyatlari.Add("Trileçe", 30.0m);
            urunFiyatlari.Add("Künefe", 30.0m);
            // Diğer ürünlerin fiyatlarını da ekleyin

            // Ürünlerin adetlerini tutacak sözlük
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
            // Diğer ürünlerin adetlerini de ekleyin

            // Kullanıcının seçtiği ürünlerin fiyatlarını ve adetlerini toplamak için değişkenler
            decimal toplamFiyat = 0;

            // Kullanıcının seçtiği ürünleri kontrol edin ve fiyatları ve adetleri toplayın
            if (checkBoxKola.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola.Text); // Kola için adet girişi yapılacak bir TextBox (txtKolaAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
            }

            if (checkBoxSu.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu.Text); // Ayran için adet girişi yapılacak bir TextBox (txtAyranAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
            }

            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
            }
            if (checkBoxCay.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
            }
            if (checkBoxTost.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
            }


            // Diğer ürünlerin seçili olup olmadığını ve adetlerini kontrol edin ve fiyatları ve adetleri toplayın
            // Aynı yöntemi diğer grup kutuları, checkbox'lar ve adet girişleri için de kullanabilirsiniz

            // Toplam fiyatı ve seçilen ürünleri göstermek için bir label veya başka bir kontrol kullanabilirsiniz
            label1.Text = $"Toplam Fiyat: {toplamFiyat} TL";
            // Ayrıca, seçilen ürünlerin adetlerini de kullanarak başka bir şekilde gösterebilirsiniz
            // Örneğin, her bir ürünün adetini ve ismini listeleyebilirsiniz
            foreach (var urun in urunAdetleri)
            {
                listBox1.Items.Add($"{urun.Key}: {urun.Value} adet");
            }








        }
    }
}
