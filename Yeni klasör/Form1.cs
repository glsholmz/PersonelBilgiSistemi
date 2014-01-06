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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void toolStripLabelYeniPersonelEkle_Click_1(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            yeniform.Show();
            
            
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form4 yeniform = new Form4();
            yeniform.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Form5 yeniform = new Form5();
            yeniform.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            localhost.Service1 service = new localhost.Service1();
            DataSet ds = service.KisiDondurad(textBoxarama.Text);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            if (checkBox1.Checked == false)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }

        }
        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            localhost.Service1 service = new localhost.Service1();
            DataSet ds = service.KisiDondurtc(textBoxarama.Text);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            checkBox2.Enabled = false;
            checkBox1.Enabled = false;
            localhost.Service1 service = new localhost.Service1();
            DataSet ds = service.KisiDondurpers(textBoxarama.Text);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
       }


        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
             localhost.Service1 myservice = new localhost.Service1();
             dataGridView1.DataSource = myservice.PersonelBilgilerini_Al().Tables[0];
            
        
        }

        

        
        



    }
}
