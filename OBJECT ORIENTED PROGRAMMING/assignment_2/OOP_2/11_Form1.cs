using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k = 0.0;

            if (radioButtonerkek.Checked == true)
            {
                k = 0.9;
            }
            else if (radioButtonkiz.Checked == true)
            {
                k = 0.8;
            }

            double boyd = double.Parse(boy.Text);
            double yil = double.Parse(tarih.Text);
            double yas = DateTime.Now.Year - yil;
            double sonuc = (boyd - 100 + yas / 10) * k;

            if (double.Parse(kilo.Text) == sonuc)
            {
                labelsonuc.Text = "Bravo! İdael kilodasınız";
            }
            else if (double.Parse(kilo.Text) > sonuc)
            {
                labelsonuc.Text = "Kilolusunuz,kilo vermelisiniz";
            }
            else if (double.Parse(kilo.Text) < sonuc)
            {
                 labelsonuc.Text = "Zayıfsınız,kilo almalısınız";
            }

            idael.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
