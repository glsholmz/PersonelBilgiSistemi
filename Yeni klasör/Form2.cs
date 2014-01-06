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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelGenelBilgiler.Location = new Point(12, 63);
            panelGenelBilgiler.Height = 961;
            panelGenelBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = true;
            panelDigerBilgiler.Visible = false;
            

            
            
        
        }


        private void toolStripLabelGenelBilgiler_Click(object sender, EventArgs e)
        {
            panelGenelBilgiler.Location = new Point(12, 63);
            panelGenelBilgiler.Height = 872;
            panelGenelBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = true;
            panelDigerBilgiler.Visible = false;
        }
            
        
        private void toolStripLabelOgrenimBilgileri_Click(object sender, EventArgs e)
        {
            panelOgrenimBilgileri.Location = new Point(12, 63);
            panelOgrenimBilgileri.Height = 872;
            panelOgrenimBilgileri.Width = 850;
            panelOgrenimBilgileri.Visible = true;
            panelGenelBilgiler.Visible = false;
            panelDigerBilgiler.Visible = false;


        }

        private void toolStripLabelDigerBilgiler_Click(object sender, EventArgs e)
        {
            panelDigerBilgiler.Location = new Point(12, 63);
            panelDigerBilgiler.Height = 872;
            panelDigerBilgiler.Width = 850;
            panelOgrenimBilgileri.Visible = false;
            panelGenelBilgiler.Visible = false;
            panelDigerBilgiler.Visible = true;

        }

        private void toolStripLabelKaydet_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            DataSet ds = new DataSet();
            try
            {
                ds = service.personel_kayit(textBoxtc.Text, textBoxad.Text, textBoxsoyad.Text, textBoxdogumyeri.Text, dateTimePickerdogumtarihi.Text, comboBoxcinsiyet.Text, textBoxuyruk.Text, textBoxunvan.Text, textBoxpersonelno.Text, textBoxpersonelno.Text, textBoxevtelefonu.Text,
                textBoxceptelefonu.Text, textBoxeposta.Text, textBoxil.Text, textBoxilce.Text, textBoxadres.Text, textBoxpersonelno.Text, dateTimePickerisegiristarihi.Text, textBoxfirma.Text, textBoxsube.Text, textBoxbirim.Text, textBoxsicilno.Text, textBoxpersonelno.Text, textBoxvergino.Text, textBoxvergidaire.Text, textBoxbanka.Text, textBoxbankasubesi.Text, textBoxbankahesapno.Text,
                textBoxpersonelno.Text, textBoxilkokuladi.Text, dateTimePickerilkokulbas.Text, dateTimePickerilkokulmezun.Text, textBoxliseokuladi.Text, dateTimePickerlisebas.Text, dateTimePickerlisemezun.Text, textBoxuniversiteokuladi.Text, textBoxuniversitebolum.Text, dateTimePickeruniversitebas.Text, dateTimePickeruniversitemezun.Text, textBoxegitimadi.Text, textBoxegitimbilgi.Text, dateTimePickeregitimbas.Text, dateTimePickeregitimbitis.Text,
                textBoxpersonelno.Text, textBoxayrilmanedeni.Text, dateTimePickerayrilmatarihi.Text, comboBoxaskerlikdurumu.Text, textBoxtecilnedeni.Text, textBoxsakatlik.Text, comboBoxmedenidurum.Text, textBoxcocuksayisi.Text, textBoxkangrubu.Text, comboBoxehliyet.Text, textBoxkizliksoyadi.Text, textBoxraporsayisi.Text, textBoxizinsayisi.Text, comboBoxservis.Text);
            }

            catch { MessageBox.Show("Eksik Bilgi Girdiniz"); }


            if (textBoxtc.Text == " " || textBoxad.Text == " " || textBoxsoyad.Text == "" || textBoxdogumyeri.Text == "" ||
            comboBoxcinsiyet.Text == "" ||
            textBoxuyruk.Text == "" ||
            textBoxunvan.Text == "" ||
            textBoxpersonelno.Text == "") { MessageBox.Show("Personel Genel Bilgilerini Eksiksiz Doldurunuz."); }

            else
            {
                MessageBox.Show("Personel kaydı yapıldı.");
                textSil();
            }
        }





        private void textSil()
        {
            textBoxtc.Text = "";
            textBoxad.Text = "";
            textBoxsoyad.Text = "";
            textBoxdogumyeri.Text="";
            resetDateTimePicker();
            comboBoxcinsiyet.Text = "";
            textBoxuyruk.Text="";
            textBoxunvan.Text="";
            textBoxpersonelno.Text="";
            textBoxevtelefonu.Text = "";
            textBoxceptelefonu.Text = "";
            textBoxil.Text = "";
            textBoxilce.Text = "";
            textBoxadres.Text = "";
            textBoxeposta.Text = "";
            textBoxfirma.Text="";
            textBoxsube.Text=""; 
            textBoxbirim.Text="";
            textBoxsicilno.Text="";
            textBoxvergino.Text="";
            textBoxvergidaire.Text="";
            textBoxbanka.Text=""; 
            textBoxbankasubesi.Text="";
            textBoxbankahesapno.Text="";
            textBoxilkokuladi.Text="";
            textBoxliseokuladi.Text = "";
            textBoxuniversiteokuladi.Text="";
            textBoxuniversitebolum.Text="";
            textBoxegitimadi.Text="";
            textBoxegitimbilgi.Text="";
            textBoxayrilmanedeni.Text=""; 
            comboBoxaskerlikdurumu.Text="";
            textBoxtecilnedeni.Text="";
            textBoxsakatlik.Text="";
            comboBoxmedenidurum.Text="";
            textBoxcocuksayisi.Text="";
            textBoxkangrubu.Text="";
            comboBoxehliyet.Text="";
            textBoxkizliksoyadi.Text="";
            textBoxraporsayisi.Text="";
            textBoxizinsayisi.Text="";
            comboBoxservis.Text="";



        }

        
        private void resetDateTimePicker() { 

               dateTimePickerdogumtarihi.Value =DateTime.Today;
                 }

        

        
            
        }
     
        

        

    }

