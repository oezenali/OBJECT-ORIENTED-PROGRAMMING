using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxHolidays.SelectedItem != null)
            {
                listBoxDays.Items.Add(comboBoxHolidays.SelectedItem + "\t" +
                    monthCalendar1.SelectionRange.Start.ToShortDateString() + " - " +
                    monthCalendar1.SelectionRange.End.ToShortDateString());
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listBoxDays.SelectedItem != null)
            {
                listBoxDays.Items.Remove(listBoxDays.SelectedItem);
            }
        }
    }
}
