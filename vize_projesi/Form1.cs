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
            urunFiyatlari.Add("Kola", 5.0m);
            urunFiyatlari.Add("gazoz", 3.0m);
            urunFiyatlari.Add("çay", 1.5m);
            urunFiyatlari.Add("kahve", 1.5m);
            urunFiyatlari.Add("çay", 1.5m);
            urunFiyatlari.Add("iskender", 1.5m);
            urunFiyatlari.Add("makarna", 1.5m);
            urunFiyatlari.Add("döner", 1.5m);
            urunFiyatlari.Add("lahmacun", 1.5m);
            urunFiyatlari.Add("künefe", 1.5m);
            urunFiyatlari.Add("pasta", 1.5m);
            // Diğer ürünlerin fiyatlarını da ekleyin

            // Ürünlerin adetlerini tutacak sözlük
            Dictionary<string, int> urunAdetleri = new Dictionary<string, int>();
            urunAdetleri.Add("Kola", 0);
            urunAdetleri.Add("Ayran", 0);
            urunAdetleri.Add("kahve", 0);
            urunAdetleri.Add("çay", 0);
            urunFiyatlari.Add("iskender", 0);
            urunFiyatlari.Add("makarna", 0);
            urunFiyatlari.Add("döner", 0);
            urunFiyatlari.Add("lahmacun", 0);
            urunFiyatlari.Add("künefe", 0);
            urunFiyatlari.Add("pasta", 0);
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
                toplamFiyat += urunFiyatlari["gazoz"] * adet;
                urunAdetleri["gazoz"] = adet;
            }

            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["çay"] * adet;
                urunAdetleri["çay"] = adet;
            }
            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["kahve"] * adet;
                urunAdetleri["kahve"] = adet;
            }
            if (checkBoxCay.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay.Text); // Su için adet girişi yapılacak bir TextBox (txtSuAdet) kullanıldığını varsayalım
                toplamFiyat += urunFiyatlari["iskender"] * adet;
                urunAdetleri["iskender"] = adet;
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
