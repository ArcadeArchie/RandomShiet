using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tracker
{
    public class SaveData
    {
        public string Project_Name { get; set; }
        public string Last_Worked_On { get; set; }
        public string Hours_Worked_On { get; set; }
        public SaveData()
        {

        }
        public SaveData(string val,string val2,string val3)
        {
            Project_Name = val;
            Last_Worked_On = val2;
            Hours_Worked_On = val3;
        }
    }
}
