using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_double
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int vize, final, proje;
            double ort;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            vize = Convert.ToInt16(textBox3.Text);
            final = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ort = (vize + final + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " Ortalama: " + ort);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string urun;
            double fiyat, kdv8, kdv18;
            urun = textBox6.Text;
            fiyat = Convert.ToDouble(textBox7.Text);
            kdv8 = fiyat + (fiyat * 8 / 100);
            kdv18 = fiyat + (fiyat * 18 / 100);
            listBox2.Items.Add("Ürün Adı: " + urun + " Yüzde 8 KDV' li fiyat: " +  kdv8 + " TL Yüzde 18 KDV' li fiyat: " + kdv18 + " TL");

        }
    }
}
