using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace process_işleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double son1, son2, son3, son4, son5;    
        double tro, diya, sek, al, tan;
        asdfg cabuk = new asdfg();

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'processDataSet2.pro' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.proTableAdapter.Fill(this.processDataSet2.pro);
            
           

        }

        double snc1, snc2, snc3, snc4, snc5, sonuc2;

        private void button1_Click(object sender, EventArgs e)
        {
            trombositlbl.Text = trombosittxt.Text;
            diyabetlbl.Text = diyabettxt.Text;
            şekerlbl.Text = şekertxt.Text;
            alyuvarlbl.Text = alyuvartxt.Text;
            tansiyonlbl.Text = tansiyontxt.Text;

            son1 = Convert.ToDouble(trombositlbl.Text);
            son2 = Convert.ToDouble(diyabetlbl.Text);
            son3 = Convert.ToDouble(şekerlbl.Text);
            son4 = Convert.ToDouble(alyuvarlbl.Text);
            son5 = Convert.ToDouble(tansiyonlbl.Text);
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            trombositprgbar.Value += 10;

            if (trombositprgbar.Value %20 == 10)
            {
                trombositgrpbox.BackColor = Color.Red;
            }
            if (trombositprgbar.Value %20 == 0)
            {
                trombositgrpbox.BackColor = Color.Green;
            }
            if (trombositprgbar.Value == 100)
            {
                timer1.Stop();

                tro = (son1 + son2 + son3 + son4 + son5) / 100 * 8 + 14;
                trombositsonlbl.Text = tro.ToString("0.00");

                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            diyabetprgbar.Value += 10;

            if (diyabetprgbar.Value %20 == 10)
            {
                diyabetgrpbox.BackColor = Color.Red;
            }
            if (diyabetprgbar.Value %20 == 0)
            {
                diyabetgrpbox.BackColor = Color.Green;
            }
            if (diyabetprgbar.Value == 100)
            {
                timer2.Stop();

                diya = (son1 + son2 + son3 + son4 + son5) / 100 * 10 + 12;
                diyabetsonlbl.Text = diya.ToString("0.00");

                timer3.Start();
            }

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            şekerprgbar.Value += 10;

            if (şekerprgbar.Value %20 == 10)
            {
                şekergrpbox.BackColor = Color.Red;
            }
            if (şekerprgbar.Value %20 == 0)
            {
                şekergrpbox.BackColor= Color.Green;
            }
            if (şekerprgbar.Value == 100)
            {
                timer3.Stop();

                sek = (son1 + son2 + son3 + son4 + son5) / 100 * 10 + 12;
                şekersonlbl.Text = sek.ToString("0.00");

                timer4.Start();
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
                alyuvarprgbar.Value += 10;

            if (alyuvarprgbar.Value %20 == 10)
            {
                alyuvargrpbox.BackColor = Color.Red;
            }
            if (alyuvarprgbar.Value %20 == 0)
            {
                alyuvargrpbox.BackColor = Color.Green;
            }
            if (alyuvarprgbar.Value == 100)
            {
                timer4.Stop();

                al = (son1 + son2 + son3 + son4 + son5) / 100 * 14 + 8;
                alyuvarsonlbl.Text = al.ToString("0.00");

                timer5.Start();
            }
            
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            tansiyonprgbar.Value += 10;

            if (tansiyonprgbar.Value %20 == 10)
            {
                tansiyongrpbox.BackColor = Color.Red;
            }
            if (tansiyonprgbar.Value %20 == 0)
            {
                tansiyongrpbox.BackColor= Color.Green;
            }
            if (tansiyonprgbar.Value == 100)
            {
                timer5.Stop();
                tan = (son1 + son2 + son3 + son4 + son5) / 100 * 16 + 6;
                tansiyonsonlbl.Text = tan.ToString("0.00");

                snc1 = Convert.ToDouble(trombositlbl.Text);
                snc2 = Convert.ToDouble(diyabetlbl.Text);
                snc3 = Convert.ToDouble(şekerlbl.Text);
                snc4 = Convert.ToDouble(alyuvarlbl.Text);
                snc5 = Convert.ToDouble(tansiyonlbl.Text);

                sonuc2 = (snc1 + snc2 + snc3 + snc4 + snc5) / 5;

                if (sonuc2 <= 100)
                {
                    sonuc2txt.Text = " Değerler Normal";
                }
                else
                {
                    sonuc2txt.Text = "Değerler Düşük";
                }
                SqlCommand veri = new SqlCommand("insert into pro (ad,soyad,tc,bolum,telefon,trombosit,diyabet,seker,alyuvar,tansiyon,sonuc) values (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)", cabuk.baglan());
                veri.Parameters.AddWithValue("@1", adtxt.Text);
                veri.Parameters.AddWithValue("@2", soyadtxt.Text);
                veri.Parameters.AddWithValue("@3", tctxt.Text);
                veri.Parameters.AddWithValue("@4", bölümtxt.Text);
                veri.Parameters.AddWithValue("@5", telefontxt.Text);
                veri.Parameters.AddWithValue("@6", trombositsonlbl.Text);
                veri.Parameters.AddWithValue("@7", diyabetsonlbl.Text);
                veri.Parameters.AddWithValue("@8", şekersonlbl.Text);
                veri.Parameters.AddWithValue("@9", alyuvarsonlbl.Text);
                veri.Parameters.AddWithValue("@10", tansiyonsonlbl.Text);
                veri.Parameters.AddWithValue("@11", sonuc2txt.Text);
                veri.ExecuteNonQuery();
                cabuk.baglan().Close();
                MessageBox.Show("İşlem Tamamlandı Ve Kayıt Başarıyla Yapıldı");
                this.proTableAdapter.Fill(this.processDataSet2.pro);

            }

        }
    }
}
