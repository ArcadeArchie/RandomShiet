using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //public static string ToHex(string data)
        //{

        //    string output = string.Empty;

        //    foreach (char c in data)
        //    {

        //        output += ((int)c).ToString("X");

        //    }

        //    return output;

        //}

        //public static string ToASCII(string hexString)
        //{
        //    try
        //    {
        //        string ascii = string.Empty;

        //        for (int i = 0; i < hexString.Length; i += 2)
        //        {
        //            String hs = string.Empty;

        //            hs = hexString.Substring(i, 2);
        //            uint decval = Convert.ToUInt32(hs, 16);
        //            char character = Convert.ToChar(decval);
        //            ascii += character;

        //        }

        //        return ascii;
        //    }
        //    catch (Exception ex) { Debug.WriteLine(ex.Message); }

        //    return string.Empty;
        //}
    }
}

