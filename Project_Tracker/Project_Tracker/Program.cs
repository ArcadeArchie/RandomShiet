using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Resources;

namespace Project_Tracker
{
    static class Program
    {
        static SheetsService service;
        public static List<SaveData> StartGoogle()
        {
            // Define request parameters.
            string spreadsheetId = Properties.Settings.Default.SpreadsheetId;
            string range = Properties.Settings.Default.Tabellenrange;
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                List<SaveData> saves = new List<SaveData>();
                foreach (var row in values)
                {
                    // Print columns A to C, which correspond to indices 0 to 2.
                    saves.Add(new SaveData(row[0].ToString(), row[1].ToString(), row[2].ToString()));
                }
                GoogleConnector.Status = "Data loaded.";
                return saves;
            }
            else
            {
                GoogleConnector.Status = "No data found.";
                //Debug.WriteLine("No data found.");
                return new List<SaveData>();
            }
        }

        public static void WriteDataToGoogle(List<IList<object>> saves)
        {
            ValueRange values = new ValueRange();
            string spreadsheetId = Properties.Settings.Default.SpreadsheetId;
            string range = Properties.Settings.Default.Tabellenrange;
            values.Range = range;
            values.Values = saves;

            var appendRequest = service.Spreadsheets.Values.Update(values, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
            Debug.WriteLine(JsonConvert.SerializeObject(appendReponse));
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            service = GoogleConnector.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
