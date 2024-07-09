using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            lblhr.Text = hScrollBarR.Value.ToString();

        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            lblhg.Text = hScrollBarG.Value.ToString();
        }

        private void vScrollBarR_Scroll(object sender, ScrollEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(vScrollBarR.Value, vScrollBarG.Value, vScrollBarB.Value);
            lblvr.Text = vScrollBarR.Value.ToString();
        }

        private void vScrollBarG_Scroll(object sender, ScrollEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(vScrollBarR.Value, vScrollBarG.Value, vScrollBarB.Value);
            lblvg.Text = vScrollBarG.Value.ToString();
        }

        private void vScrollBarB_Scroll(object sender, ScrollEventArgs e)
        {
            label1.ForeColor = Color.FromArgb(vScrollBarR.Value, vScrollBarG.Value, vScrollBarB.Value);
            lblvb.Text = vScrollBarB.Value.ToString();
        }

        private void hScrollBarB_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBarR.Value, hScrollBarG.Value, hScrollBarB.Value);
            lblhb.Text = hScrollBarB.Value.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
