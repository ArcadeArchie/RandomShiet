# RandomShiet



## Project Tracker
A simple project track with functionality to Read/Write to a Google Spreadsheet or local file

### Using Google
If you want to save the data to a google spreadsheet [follow](https://developers.google.com/sheets/api/quickstart/dotnet) the .NET guide
for the Google Sheets API and get a credentials.json and save it to where the other files are.
And edit in Program.cs the lines 23,24 and 52,53.
```csharp
String spreadsheetId = "<Put your SpreadsheetID here>";
String range = "<Set here the Edit range>";
```
And now pretty much good to go. Im open for any ideas and improvements for the programm. 
