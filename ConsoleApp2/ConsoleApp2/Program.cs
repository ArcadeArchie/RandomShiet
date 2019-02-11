using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        public static string inputString;
        private static bool Continue = true;
        static void Main(string[] args)
        {
            while (Continue)
            {
                Console.WriteLine("Convert to Hex(h) or ASCII(a)");
                var inchar = Console.ReadLine();
                if (inchar == "a")
                {
                    inputString = Console.ReadLine();
                    Console.WriteLine(ToASCII(inputString));
                    Console.ReadKey();
                    Console.WriteLine("Continue?(yes/no)");
                    var Cher = Console.ReadLine();
                    if (Cher == "yes")
                    {

                    }
                    else if (Cher == "no")
                    {
                        Continue = false;
                    }
                    else
                    {
                        Console.WriteLine("Fatal error exiting :)");
                        Thread.Sleep(1000);
                        Environment.Exit(1);
                    }
                }
                else if (inchar == "h")
                {
                    inputString = Console.ReadLine();
                    Console.WriteLine(ToHex(inputString));
                    Console.ReadKey();
                    Console.WriteLine("Continue?(yes/no)");
                    var Cher = Console.ReadLine();
                    if (Cher == "yes")
                    {
                        inputString = null;
                        inchar = null;
                    }
                    else if (Cher == "no")
                    {
                        Continue = false;
                    }
                    else
                    {
                        Console.WriteLine("Fatal error exiting :)");
                        Thread.Sleep(1000);
                        Environment.Exit(1);
                    }
                }
            }

        }

        public static string ToHex(string data)
        {

            string output = string.Empty;

            foreach (char c in data)
            {

                output += ((int)c).ToString("X");

            }

            return output;

        }
        public static string ToASCII(string hexString)
        {
            try
            {
                string ascii = string.Empty;

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
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }
}

