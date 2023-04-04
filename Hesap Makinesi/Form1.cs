using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        double _ilkSayi;
        //double? gecmis = 0, sonuc, sayi;
        //string sonsayi, islem;
       // bool hareket, nokta;
        public Form1()
        {
            InitializeComponent();
        }

        private void sayi_bir_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "1";
        }

        private void sayi_iki_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "2";
        }

        private void sayi_uc_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "3";
        }

        private void sayi_dort_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "4";
        }

        private void sayi_bes_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "5";
        }

        private void sayi_alti_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "6";
        }

        private void sayi_yedi_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "7";
        }

        private void sayi_sekiz_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "8";
        }

        private void sayi_dokuz_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "9";
        }

        private void sayi_sifir_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                hesap_ekran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (hesap_ekran.Text == "0") hesap_ekran.Text = "";
            hesap_ekran.Text += "0";
        }

        private void toplama_Click(object sender, EventArgs e)
        {

            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text); 

        }
        double sonuc;
        private void esittir_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(hesap_ekran.Text);
            
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                case 'x':
                    sonuc = _ilkSayi * _ilkSayi;
                    break;
                case '%':
                    sonuc = _ilkSayi / 100;
                    break;
                case '√':
                    sonuc = Math.Sqrt(_ilkSayi);
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            hesap_ekran.Text = Convert.ToString(sonuc);
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void button15_Click(object sender, EventArgs e) //bölme işlemi
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hesap_ekran.Text = "0";
        }

        private void kok_alma_Click(object sender, EventArgs e)
        {
            _islem = '√';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void kare_alma_Click(object sender, EventArgs e) // karesini alma
        {
            _islem = 'x';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void yuzde_alma_Click(object sender, EventArgs e)
        {
            _islem = '%';
            _ekranTemizlenecekMi = true;
           _ilkSayi = Convert.ToDouble(hesap_ekran.Text);
        }

        private void button1_Click(object sender, EventArgs e) //tek tek silme butonu (CE)
        {
            hesap_ekran.Text = hesap_ekran.Text.Substring(0, hesap_ekran.Text.Length - 1);
            if (hesap_ekran.Text=="")
            {
                hesap_ekran.Text = "0";
            }
        }

        private void virgul_Click(object sender, EventArgs e) // ondalıklı sayı hesabı yapmak için
        {
            if ((hesap_ekran.Text== "") | (hesap_ekran.Text.EndsWith (",")))
            {
                hesap_ekran.Text += "";
            }
            else
            {
                hesap_ekran.Text += ",";
            }
        }
    }
}
    
    

  