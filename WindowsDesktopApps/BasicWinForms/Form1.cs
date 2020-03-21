using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegacyWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoToSomewhere_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(2020, 4, 16);
            monthCalendar1.SelectionStart = dateTime;
            monthCalendar1.SelectionEnd = dateTime;

        }

        private void btnAmraBDay_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(2020, 5, 4);
            monthCalendar1.SelectionStart = dateTime;
            monthCalendar1.SelectionEnd = dateTime;
        }
    }
}
