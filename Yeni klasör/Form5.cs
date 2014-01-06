using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Bilgi_Sistemi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        public void admingirisi()
        {
            string kadi = textBoxkullaniciadi.Text;
            string sifre = textBoxsifre.Text;


            if ((textBoxkullaniciadi.Text == "") && (textBoxsifre.Text == ""))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Girmediniz");
            }


            if (kadi != null & sifre != null)
            {
                if (kadi == "admin" && sifre == "admin")
                {
                    
                    Form6 yeniform = new Form6();
                    yeniform.Show();
                    this.Close();
                    
                }
                else
                { MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admingirisi();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBoxsifre.PasswordChar = (char)42;
        }
    }
}
