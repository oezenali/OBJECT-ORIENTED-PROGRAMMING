using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem)
            {
                case "metre":
                    textBox2.Text = "metre";
                    break;
                case "Inch":
                    textBox2.Text = "Inch";
                    break;
                case "foot":
                    textBox2.Text = "foot";
                    break;
                case "yarda":
                    textBox2.Text = "yarda";
                    break;
                case "kara mili":
                    textBox2.Text = "kara mili";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "metre":
                    textBox4.Text = "metre";
                    break;
                case "Inch":
                    textBox4.Text = "Inch";
                    break;
                case "foot":
                    textBox4.Text = "foot";
                    break;
                case "yarda":
                    textBox4.Text = "yarda";
                    break;
                case "kara mili":
                    textBox4.Text = "kara mili";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem !=null)
            {
                double inchToMetre = double.Parse(textBox1.Text) / 39.3701;
                double footToMetre = double.Parse(textBox1.Text) / 3.28084;
                double yardaToMetre = double.Parse(textBox1.Text) / 1.09361;
                double karaMiliToMetre = double.Parse(textBox1.Text) / 0.00062137;
                switch (comboBox1.SelectedItem)
                {
                    case "metre" when comboBox2.SelectedItem == "metre":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1).ToString();
                        break;
                    case "metre" when comboBox2.SelectedItem == "Inch":
                        textBox3.Text = (double.Parse(textBox1.Text) * 39.3701).ToString();
                        break;
                    case "metre" when comboBox2.SelectedItem == "foot":
                        textBox3.Text = (double.Parse(textBox1.Text) * 3.28084).ToString();
                        break;
                    case "metre" when comboBox2.SelectedItem == "yarda":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1.09361).ToString();
                        break;
                    case "metre" when comboBox2.SelectedItem == "kara mili":
                        textBox3.Text = (double.Parse(textBox1.Text) * 0.00062137).ToString();
                        break;

                    case "Inch" when comboBox2.SelectedItem == "metre":
                        textBox3.Text = inchToMetre.ToString();
                        break;
                    case "Inch" when comboBox2.SelectedItem == "Inch":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1).ToString();
                        break;
                    case "Inch" when comboBox2.SelectedItem == "foot":
                        textBox3.Text = (inchToMetre * 3.28084).ToString();
                        break;
                    case "Inch" when comboBox2.SelectedItem == "yarda":
                        textBox3.Text = (inchToMetre * 1.09361).ToString();
                        break;
                    case "Inch" when comboBox2.SelectedItem == "kara mili":
                        textBox3.Text = (inchToMetre * 0.00062137).ToString();
                        break;

                    case "foot" when comboBox2.SelectedItem == "metre":
                        textBox3.Text = (footToMetre).ToString();
                        break;
                    case "foot" when comboBox2.SelectedItem == "Inch":
                        textBox3.Text = (footToMetre * 39.3701).ToString();
                        break;
                    case "foot" when comboBox2.SelectedItem == "foot":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1).ToString();
                        break;
                    case "foot" when comboBox2.SelectedItem == "yarda":
                        textBox3.Text = (footToMetre * 1.09361).ToString();
                        break;
                    case "foot" when comboBox2.SelectedItem == "kara mili":
                        textBox3.Text = (footToMetre * 0.00062137).ToString();
                        break;

                    case "yarda" when comboBox2.SelectedItem == "metre":
                        textBox3.Text = yardaToMetre.ToString();
                        break;
                    case "yarda" when comboBox2.SelectedItem == "Inch":
                        textBox3.Text = (yardaToMetre * 39.3701).ToString();
                        break;
                    case "yarda" when comboBox2.SelectedItem == "foot":
                        textBox3.Text = (yardaToMetre * 3.28084).ToString();
                        break;
                    case "yarda" when comboBox2.SelectedItem == "yarda":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1).ToString();
                        break;
                    case "yarda" when comboBox2.SelectedItem == "kara mili":
                        textBox3.Text = (yardaToMetre * 0.00062137).ToString();
                        break;

                    case "kara mili" when comboBox2.SelectedItem == "metre":
                        textBox3.Text = karaMiliToMetre.ToString();
                        break;
                    case "kara mili" when comboBox2.SelectedItem == "Inch":
                        textBox3.Text = (karaMiliToMetre * 39.3701).ToString();
                        break;
                    case "kara mili" when comboBox2.SelectedItem == "foot":
                        textBox3.Text = (karaMiliToMetre * 3.28084).ToString();
                        break;
                    case "kara mili" when comboBox2.SelectedItem == "yarda":
                        textBox3.Text = (karaMiliToMetre * 1.09361).ToString();
                        break;
                    case "kara mili" when comboBox2.SelectedItem == "kara mili":
                        textBox3.Text = (double.Parse(textBox1.Text) * 1).ToString();
                        break;
                }

            }
            else if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                double kwTokgf = double.Parse(textBox8.Text) / 0.0098;
                double kcalTokgf = double.Parse(textBox8.Text) / 0.00234;
                double psTokgf = double.Parse(textBox8.Text) / 0.0133;
                switch (comboBox4.SelectedItem)
                {
                    case "kgf.m/s" when comboBox3.SelectedItem == "kgf.m/s":
                        textBox6.Text = (double.Parse(textBox8.Text) * 1).ToString();
                        break;
                    case "kgf.m/s" when comboBox3.SelectedItem == "Kw":
                        textBox6.Text = (double.Parse(textBox8.Text) * 0.0098).ToString();
                        break;
                    case "kgf.m/s" when comboBox3.SelectedItem == "Kcal/s":
                        textBox6.Text = (double.Parse(textBox8.Text) * 0.00234).ToString();
                        break;  
                    case "kgf.m/s" when comboBox3.SelectedItem == "PS":
                        textBox6.Text = (double.Parse(textBox8.Text) * 0.0133).ToString();
                        break; 
                    
                    case "Kw" when comboBox3.SelectedItem == "kgf.m/s":
                        textBox6.Text = kwTokgf.ToString();
                        break; 
                    case "Kw" when comboBox3.SelectedItem == "Kw":
                        textBox6.Text = (double.Parse(textBox8.Text) * 1).ToString();
                        break;
                    case "Kw" when comboBox3.SelectedItem == "Kcal/s":
                        textBox6.Text = (kwTokgf * 0.00234).ToString();
                        break;
                    case "Kw" when comboBox3.SelectedItem == "PS":
                        textBox6.Text = (kwTokgf * 0.0133).ToString();
                        break;

                    case "Kcal/s" when comboBox3.SelectedItem == "kgf.m/s":
                        textBox6.Text = kcalTokgf.ToString();
                        break;
                    case "Kcal/s" when comboBox3.SelectedItem == "Kw":
                        textBox6.Text = (kcalTokgf * 0.0098).ToString();
                        break;
                    case "Kcal/s" when comboBox3.SelectedItem == "Kcal/s":
                        textBox6.Text = (double.Parse(textBox8.Text) * 1).ToString();
                        break;
                    case "Kcal/s" when comboBox3.SelectedItem == "PS":
                        textBox6.Text = (kcalTokgf * 0.0133).ToString();
                        break;

                    case "PS" when comboBox3.SelectedItem == "kgf.m/s":
                        textBox6.Text = psTokgf.ToString();
                        break;
                    case "PS" when comboBox3.SelectedItem == "Kw":
                        textBox6.Text = (psTokgf * 0.0098).ToString();
                        break;
                    case "PS" when comboBox3.SelectedItem == "Kcal/s":
                        textBox6.Text = (psTokgf * 0.00234).ToString();
                        break;
                    case "PS" when comboBox3.SelectedItem == "PS":
                        textBox6.Text = (double.Parse(textBox8.Text) * 1).ToString();
                        break;
                 
                    }
                }
                else if (comboBox6.SelectedItem != null && comboBox5.SelectedItem != null)
                {
                    double psiToAtm = double.Parse(textBox12.Text) / 14.65;
                    double barToAtm = double.Parse(textBox12.Text) / 1.01;

                    switch (comboBox6.SelectedItem)
                    {
                        case "atm" when comboBox5.SelectedItem == "atm":
                            textBox10.Text = (double.Parse(textBox12.Text) * 1).ToString();
                            break;

                        case "atm" when comboBox5.SelectedItem == "psi":
                            textBox10.Text = (double.Parse(textBox12.Text) * 14.65).ToString();
                            break;
                        case "atm" when comboBox5.SelectedItem == "bar":
                            textBox10.Text = (double.Parse(textBox12.Text) * 1.01).ToString();
                            break;

                        case "psi" when comboBox5.SelectedItem == "atm":
                            textBox10.Text = psiToAtm.ToString();
                            break;
                        case "psi" when comboBox5.SelectedItem == "psi":
                            textBox10.Text = (double.Parse(textBox12.Text) * 1).ToString();
                            break;
                        case "psi" when comboBox5.SelectedItem == "bar":
                            textBox10.Text = (psiToAtm * 1.01).ToString();
                            break;

                        case "bar" when comboBox5.SelectedItem == "atm":
                            textBox10.Text = barToAtm.ToString();
                            break;
                        case "bar" when comboBox5.SelectedItem == "psi":
                            textBox10.Text = (barToAtm * 14.65).ToString();
                            break;
                        case "bar" when comboBox5.SelectedItem == "bar":
                            textBox10.Text = (double.Parse(textBox12.Text) * 1).ToString();
                            break;
                    }
                }



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (comboBox3.SelectedItem)
            {
                case "kgf.m/s":
                    textBox5.Text = "kgf.m/s";
                    break;  
                case "Kw":
                    textBox5.Text = "Kw";
                    break;
                case "Kcal/s":
                    textBox5.Text = "Kcal / s";
                    break;
                case "PS":
                    textBox5.Text = "PS";
                    break;
            }

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem)
            {
                case "kgf.m/s":
                    textBox7.Text = "kgf.m/s";
                    break;
                case "Kw":
                    textBox7.Text = "Kw";
                    break;
                case "Kcal/s":
                    textBox7.Text = "Kcal / s";
                    break;
                case "PS":
                    textBox7.Text = "PS";
                    break;
            }

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.SelectedItem)
            {
                case "atm":
                    textBox11.Text = "atm";
                    break;
                case "psi":
                    textBox11.Text = "psi";
                    break;
                case "bar":
                    textBox11.Text = "bar";
                    break;
               
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedItem)
            {
                case "atm":
                    textBox9.Text = "atm";
                    break;
                case "psi":
                    textBox9.Text = "psi";
                    break;
                case "bar":
                    textBox9.Text = "bar";
                    break;

            }
        }
    }
}
