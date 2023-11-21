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

        public static decimal toplam = 0;
        public static decimal toplamFiyat1 = 0;
        public static decimal toplamFiyat2= 0;
        public static decimal toplamFiyat3 = 0;
        public static decimal toplamFiyat4 = 0;
        public static decimal toplamFiyat5 = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            
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

          
            if (checkBoxKola.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola.Text);
                toplamFiyat1 += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
                listBox1.Items.Add($"{adet} adet Kola vardır. {toplamFiyat1} TL'dir");
            }

            if (checkBoxSu.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu.Text);
                toplamFiyat1 += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
                listBox1.Items.Add($"{adet} adet Su vardır. {toplamFiyat1} TL'dir");

            }

            if (checkBoxFanta.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta.Text);
                toplamFiyat1 += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
                listBox1.Items.Add($"{adet} adet Fanta vardır. {toplamFiyat1} TL'dir");

            }
            if (checkBoxCay.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay.Text);
                toplamFiyat1 += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
                listBox1.Items.Add($"{adet} adet Çay vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxTost.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost.Text);
                toplamFiyat1 += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
                listBox1.Items.Add($"{adet} adet Tost vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxIskender.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender.Text);
                toplamFiyat1 += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
                listBox1.Items.Add($"{adet} adet İskender vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxDoner.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner.Text);
                toplamFiyat1 += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
                listBox1.Items.Add($"{adet} adet Döner vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxCigKofte.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte.Text);
                toplamFiyat1 += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
                listBox1.Items.Add($"{adet} adet Çiğ Köfte vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxTrilece.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece.Text);
                toplamFiyat1 += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
                listBox1.Items.Add($"{adet} adet Trileçe vardır. {toplamFiyat1} TL'dir");
            }
            if (checkBoxKunefe.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe.Text);
                toplamFiyat1 += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
                listBox1.Items.Add($"{adet} adet Künefe vardır. {toplamFiyat1} TL'dir");
            }
            
            //Verileri listboxa bastırma

            if (OnayPenceresiGoster("Ödeme yapmak istediğinize emin misiniz?"))
            {

            }
            toplam += toplamFiyat1;


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
           

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola2.Text);
                toplamFiyat2 += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
                listBox1.Items.Add($"{adet} adet Kola vardır. {toplamFiyat2} TL'dir");

            }

            if (checkBoxSu2.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu2.Text);
                toplamFiyat2 += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
                listBox1.Items.Add($"{adet} adet Su vardır. {toplamFiyat2} TL'dir");

            }

            if (checkBoxFanta2.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta2.Text);
                toplamFiyat2 += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
                listBox1.Items.Add($"{adet} adet Fanta vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxCay2.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay2.Text);
                toplamFiyat2 += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
                listBox1.Items.Add($"{adet} adet Çay vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxTost2.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost2.Text);
                toplamFiyat2 += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
                listBox1.Items.Add($"{adet} adet Tost vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxIskender2.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender2.Text);
                toplamFiyat2 += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
                listBox1.Items.Add($"{adet} adet İskender vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxDoner2.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner2.Text);
                toplamFiyat2 += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
                listBox1.Items.Add($"{adet} adet Döner vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxCigKofte2.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte2.Text);
                toplamFiyat2 += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
                listBox1.Items.Add($"{adet} adet Çiğ Köfte vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxTrilece2.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece2.Text);
                toplamFiyat2 += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
                listBox1.Items.Add($"{adet} adet Trileçe vardır. {toplamFiyat2} TL'dir");

            }
            if (checkBoxKunefe2.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe2.Text);
                toplamFiyat2 += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
                listBox1.Items.Add($"{adet} adet Künefe vardır. {toplamFiyat2} TL'dir");

            }
            if (OnayPenceresiGoster("Ödeme yapmak istediğinize emin misiniz?"))
            {

            }
            toplam += toplamFiyat2;

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
           

            // Kullanıcının seçtiği ürünleri kontrol et, fiyatları ve adetleri topla.
            if (checkBoxKola3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola3.Text);
                toplamFiyat3 += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
                 listBox1.Items.Add($"{adet} adet Kola vardır. {toplamFiyat3} TL'dir");
            }

            if (checkBoxSu3.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu3.Text);
                toplamFiyat3 += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
                 listBox1.Items.Add($"{adet} adet Su vardır. {toplamFiyat3} TL'dir");
            }

            if (checkBoxFanta3.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta3.Text);
                toplamFiyat3 += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
                listBox1.Items.Add($"{adet} adet Fanta vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxCay3.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay3.Text);
                toplamFiyat3 += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
                 listBox1.Items.Add($"{adet} adet Çay vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxTost3.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost3.Text);
                toplamFiyat3 += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
                listBox1.Items.Add($"{adet} adet Tost vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxIskender3.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender3.Text);
                toplamFiyat3 += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
                                listBox1.Items.Add($"{adet} adet İskender vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxDoner3.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner3.Text);
                toplamFiyat3 += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
                                listBox1.Items.Add($"{adet} adet Döner vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxCigKofte3.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte3.Text);
                toplamFiyat3 += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
                                listBox1.Items.Add($"{adet} adet Çiğköfte vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxTrilece3.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece3.Text);
                toplamFiyat3 += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
                                listBox1.Items.Add($"{adet} adet Trileçe vardır. {toplamFiyat3} TL'dir");
            }
            if (checkBoxKunefe3.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe3.Text);
                toplamFiyat3 += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
                                listBox1.Items.Add($"{adet} adet Künefe vardır. {toplamFiyat3} TL'dir");
            }
            if (OnayPenceresiGoster("Ödeme yapmak istediğinize emin misiniz?"))
            {

            }
            toplam += toplamFiyat3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
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


            if (checkBoxKola4.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola4.Text);
                toplamFiyat4 += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
                listBox1.Items.Add($"{adet} adet Kola vardır. {toplamFiyat4} TL'dir");
            }

            if (checkBoxSu4.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu4.Text);
                toplamFiyat4 += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
                                listBox1.Items.Add($"{adet} adet Su vardır. {toplamFiyat4} TL'dir");
            }

            if (checkBoxFanta4.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta4.Text);
                toplamFiyat4 += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
                                listBox1.Items.Add($"{adet} adet Fanta vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxCay4.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay4.Text);
                toplamFiyat4 += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
                                listBox1.Items.Add($"{adet} adet Çay vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxTost4.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost4.Text);
                toplamFiyat4 += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
                                listBox1.Items.Add($"{adet} adet Tost vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxIskender4.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender4.Text);
                toplamFiyat4 += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
                                listBox1.Items.Add($"{adet} adet İskender vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxDoner4.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner4.Text);
                toplamFiyat4 += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
                                listBox1.Items.Add($"{adet} adet Döner vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxCigKofte4.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte4.Text);
                toplamFiyat4 += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
                                listBox1.Items.Add($"{adet} adet Çiğköfte vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxTrilece4.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece4.Text);
                toplamFiyat4 += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
                                listBox1.Items.Add($"{adet} adet Trileçe vardır. {toplamFiyat4} TL'dir");
            }
            if (checkBoxKunefe4.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe4.Text);
                toplamFiyat4 += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
                                listBox1.Items.Add($"{adet} adet Künefe vardır. {toplamFiyat4} TL'dir");
            }
            if (OnayPenceresiGoster("Ödeme yapmak istediğinize emin misiniz?"))
            {

            }
            toplam += toplamFiyat4;

        }

        private bool OnayPenceresiGoster(string mesaj)
        {
            string onayMesaji = "Onaylanmadı";

            DialogResult result = MessageBox.Show(mesaj, "Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                onayMesaji = "Onaylandı";
                Odeme form2 = new Odeme(listBox1.Items.Cast<string>().ToList());
                form2.Show();


            }
            else
            {

            }

            MessageBox.Show(onayMesaji, "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return result == DialogResult.Yes;
        }

        

        private void button5_Click(object sender, EventArgs e)
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


            if (checkBoxKola5.Checked)
            {
                int adet = Convert.ToInt32(textBoxKola5.Text);
                toplamFiyat5 += urunFiyatlari["Kola"] * adet;
                urunAdetleri["Kola"] = adet;
                 listBox1.Items.Add($"{adet} adet Kola vardır. {toplamFiyat5} TL'dir");
            }

            if (checkBoxSu5.Checked)
            {
                int adet = Convert.ToInt32(textBoxSu5.Text);
                toplamFiyat5 += urunFiyatlari["Su"] * adet;
                urunAdetleri["Su"] = adet;
                                listBox1.Items.Add($"{adet} adet Su vardır. {toplamFiyat5} TL'dir");
            }

            if (checkBoxFanta5.Checked)
            {
                int adet = Convert.ToInt32(textBoxFanta5.Text);
                toplamFiyat5 += urunFiyatlari["Fanta"] * adet;
                urunAdetleri["Fanta"] = adet;
                                listBox1.Items.Add($"{adet} adet Fanta vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxCay5.Checked)
            {
                int adet = Convert.ToInt32(textBoxCay5.Text);
                toplamFiyat5 += urunFiyatlari["Çay"] * adet;
                urunAdetleri["Çay"] = adet;
                                listBox1.Items.Add($"{adet} adet Çay vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxTost5.Checked)
            {
                int adet = Convert.ToInt32(textBoxTost5.Text);
                toplamFiyat5 += urunFiyatlari["Tost"] * adet;
                urunAdetleri["Tost"] = adet;
                                listBox1.Items.Add($"{adet} adet Tost vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxIskender5.Checked)
            {
                int adet = Convert.ToInt32(textBoxIskender5.Text);
                toplamFiyat5 += urunFiyatlari["İskender"] * adet;
                urunAdetleri["İskender"] = adet;
                                listBox1.Items.Add($"{adet} adet İskender vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxDoner5.Checked)
            {
                int adet = Convert.ToInt32(textBoxDoner5.Text);
                toplamFiyat5 += urunFiyatlari["Döner"] * adet;
                urunAdetleri["Döner"] = adet;
                                listBox1.Items.Add($"{adet} adet Döner vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxCigKofte5.Checked)
            {
                int adet = Convert.ToInt32(textBoxCigKofte5.Text);
                toplamFiyat5 += urunFiyatlari["Çiğ Köfte"] * adet;
                urunAdetleri["Çiğ Köfte"] = adet;
                                listBox1.Items.Add($"{adet} adet Çiğköfte vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxTrilece5.Checked)
            {
                int adet = Convert.ToInt32(textBoxTrilece5.Text);
                toplamFiyat5 += urunFiyatlari["Trileçe"] * adet;
                urunAdetleri["Trileçe"] = adet;
                                listBox1.Items.Add($"{adet} adet Trileçe vardır. {toplamFiyat5} TL'dir");
            }
            if (checkBoxKunefe5.Checked)
            {
                int adet = Convert.ToInt32(textBoxKunefe5.Text);
                toplamFiyat5 += urunFiyatlari["Künefe"] * adet;
                urunAdetleri["Künefe"] = adet;
                listBox1.Items.Add($"{adet} adet Künefe vardır. {toplamFiyat5} TL'dir");
            }
            if (OnayPenceresiGoster("Ödeme yapmak istediğinize emin misiniz?"))
            {

            }
            toplam += toplamFiyat5;

        }
    }
}
