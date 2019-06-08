using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saves = new List<SaveData>();
        }
        DateTime currentDate = new DateTime();
        public List<SaveData> saves;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                button1.Text = "Stop Timer";
                timer1.Enabled = false;
                timer1.Stop();
                listView1.Items.Add(ProjectNameBox.Text + "\n" + currentDate.ToShortDateString() + "\n" + textBox1.Text);
                saves.Add(new SaveData(ProjectNameBox.Text,DateTime.Now.ToString(),textBox1.Text));
            }
            else if (!timer1.Enabled)
            {
                button1.Text = "Start Timer";
                currentDate = DateTime.Now;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + filebox.Text + ".txt";
            string output = File.ReadAllText(path);
            var json = JsonConvert.DeserializeObject<List<SaveData>>(output);
            listView1.Items.Clear();
            saves.Clear();
            foreach (SaveData item in json)
            {
                saves.Add(item);
                listView1.Items.Add(item.Project_Name + "\n" + item.Last_Worked_On + "\n" + item.Hours_Worked_On);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + filebox.Text + ".txt";
            StringBuilder sb = new StringBuilder();
                var sav = JsonConvert.SerializeObject(saves);
                sb.AppendLine(sav);
            File.WriteAllText(path, sb.ToString());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            System.TimeSpan diff = currentDate.Subtract(DateTime.Now);
            textBox1.Text = diff.ToString().Replace("-", "");
        }

        private void LoadDataFromGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            saves = Program.StartGoogle();
            foreach (SaveData item in saves)
            {
                listView1.Items.Add(item.Project_Name + "\n" + item.Last_Worked_On + "\n" + item.Hours_Worked_On);
            }
            textBox1.Text = GoogleConnector.Status;
        }

        private void SaveDataToGoogleToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var obj = new List<IList<object>>();
            foreach (var item in saves)
            {
               obj.Add(new List<object> { item.Project_Name,item.Last_Worked_On,item.Hours_Worked_On });
            }
            Program.WriteDataToGoogle(obj);
        }
    }
}
