using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Converts the given string into Hexadecimal
        public string ToHex(string data)
        {

            string output = string.Empty;
            //Converts every char in data into Hexdeciamal
            foreach (char c in data)
            {

                output += ((int)c).ToString("X");

            }

            return output;

        }
        //Converts a Hexadecimal string into ASCII
        public string ToASCII(string hexString)
        {
            try
            {
                string ascii = string.Empty;
                //Converts the hexString into ASCII
                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = Convert.ToUInt32(hs, 16);
                    char character = Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }

            return string.Empty;
        }

        //Checks if the user wants to convert into Hex or ASCII
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                richTextBox2.Text = ToHex(richTextBox1.Text.ToString());
            }
            if (checkBox2.Checked && !checkBox1.Checked)
            {
                richTextBox2.Text = ToASCII(richTextBox1.Text.ToString());
            }
        }
    }
}
