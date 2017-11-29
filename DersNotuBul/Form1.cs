using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DersNotuBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            //formül = (70 / sınıfOrtalaması + 1) * 0,5
            double formul = ((70 / Convert.ToDouble(txt_SinifOrtalaması.Text)) + 1) * 0.5;
            //string ortalamaDeger = formul.ToString("0.##");
            double ortalamaDeger = Math.Round(formul, 2);


            //lbl_DDAltSinir.Text = (70 / Convert.ToDouble(ortalamaDeger)).ToString();
            double dd_AltSinir = 50 / ortalamaDeger;
            lbl_DDAltSinir.Text = (Math.Round(dd_AltSinir, 2)).ToString();
            double dc_AltSinir = 60 / ortalamaDeger;
            lbl_DCAltSinir.Text = (Math.Round(dc_AltSinir, 2)).ToString();
            double cc_AltSinir = 70 / ortalamaDeger;
            lbl_CCAltSinir.Text = (Math.Round(cc_AltSinir, 2)).ToString();
            double cb_AltSinir = 80 / ortalamaDeger;
            lbl_CBAltSinir.Text = (Math.Round(cb_AltSinir, 2)).ToString();
            double bb_Altsinir = 90 / ortalamaDeger;
            lbl_BBAltSinir.Text = (Math.Round(bb_Altsinir, 2)).ToString();
            double ba_Altsinir = 100 / ortalamaDeger;
            lbl_BAAltSinir.Text = (Math.Round(ba_Altsinir, 2)).ToString();
            

            {
                int kullaniciNotu = Convert.ToInt32(txt_KullaniciNotu.Text);
                double oortalamaDeger = Convert.ToDouble(txt_SinifOrtalaması.Text);
                if (kullaniciNotu > dd_AltSinir && kullaniciNotu < dc_AltSinir)
            {
                lbl_Not.Text = "DD";
            }
            else if (kullaniciNotu >= dc_AltSinir && kullaniciNotu < cc_AltSinir)
            {
                lbl_Not.Text = "DC";
            }
            else if (kullaniciNotu >= cc_AltSinir && kullaniciNotu < cb_AltSinir)
            {
                lbl_Not.Text = "CC";
            }

            else if (kullaniciNotu >= cb_AltSinir && kullaniciNotu < bb_Altsinir)
            {
                lbl_Not.Text = "CB";
            }
            else if (kullaniciNotu >= bb_Altsinir && kullaniciNotu < ba_Altsinir)
            {
                lbl_Not.Text = "BB";
            }
            else if (kullaniciNotu >= ba_Altsinir && kullaniciNotu < aa_Altsinir)
            {
                lbl_Not.Text = "BA";
            }
            else if (kullaniciNotu >= aa_Altsinir)
                
            {
                lbl_Not.Text = "AA";
            }
                double SinifOrtalaması = Convert.ToDouble(txt_SinifOrtalaması.Text);
                  if (SinifOrtalaması >= 70 && kullaniciNotu <= 75)
                {
                    lbl_Not.Text = "CC";

                }
       
               else if (SinifOrtalaması >= 70 && kullaniciNotu >= 75 && kullaniciNotu < 80)
                {
                    lbl_Not.Text = "CB";
                }

                else if (SinifOrtalaması >= 70 && kullaniciNotu >= 80 && kullaniciNotu < 85)
                {
                    lbl_Not.Text = "BB";
                }

                else if (SinifOrtalaması >= 70 && kullaniciNotu >= 85 && kullaniciNotu < 90)
                {
                    lbl_Not.Text = "BA";
                }

                else if (SinifOrtalaması >= 70 && kullaniciNotu >= 90 && kullaniciNotu < 100)
                {
                    lbl_Not.Text = "AA";
                }

                pnl_Sinirlar.Visible = true;
          
            }
          
          
            


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Sinirlar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Not_Click(object sender, EventArgs e)
        {

        }
    }
}
