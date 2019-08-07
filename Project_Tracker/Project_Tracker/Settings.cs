using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tracker
{
    public partial class Settings : MaterialForm
    {
        public Settings()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.SpreadsheetId;
            textBox2.Text = Properties.Settings.Default.Tabellenrange;
        }

        private void SetTablerange_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SpreadsheetId = textBox1.Text;
        }

        private void SpreadsheetID_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Tabellenrange = textBox2.Text;
        }
    }
}
