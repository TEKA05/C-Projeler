using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarişmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSNR.Enabled = true;

            label8.Text = btnB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSNR.Enabled = true;

            label8.Text = btnC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSNR.Enabled = true;

            label8.Text = btnD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSNR.Enabled = true;


            label8.Text = btnA.Text;
            if(label7.Text==label8.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSNR_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSNR.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoru.Text = soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ? ";
                btnA.Text = "1932";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label7.Text = "1923";
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangi şehir Ege Bölgesinde bulunmaz ? ";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label7.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazara aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Nazım Hikmet";
                label7.Text= "Sait Faik";
                btnSNR.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSNR.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n " + "Yanlış: " + yanlis);
            }
        }
    }
}
