using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi_Örneği
{
    
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilksayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "1";
        }

        private void rakam2buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "2";
        }

        private void rakam3buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "3";
        }

        private void rakam4buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "4";
        }

        private void rakam5buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "5";
        }

        private void rakam6buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "6";
        }

        private void rakam7buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "7";
        }

        private void rakam8buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "8";
        }

        private void rakam9buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "9";
        }

        private void rakam0buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranlabel.Text == "0")
            {
                ekranlabel.Text = "";
            }
            ekranlabel.Text += "0";
        }

        private void toplabuton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranlabel.Text);
        }

        private void eşittirbuton_Click(object sender, EventArgs e)
        {
            int ikincisayı = Convert.ToInt32(ekranlabel.Text);
            int sonuc ;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayı + ikincisayı;
                    break;
                case '-':
                    sonuc = _ilksayı - ikincisayı;
                    break;
                case '*':
                    sonuc = _ilksayı * ikincisayı;
                    break;
                case '/':
                    sonuc = _ilksayı / ikincisayı;
                    break;
                default:
                    sonuc = 0;
                    break;
               
                   
            }

            ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void çıkarbuton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranlabel.Text);
        }

        private void çarpbuton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranlabel.Text);
        }

        private void bölbuton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayı = Convert.ToInt32(ekranlabel.Text);
        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";
        }
    }
}
