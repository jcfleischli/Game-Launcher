using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.ComponentModel;
using System.Net;
using System.Security.Cryptography;

namespace Launcher
{
  class Update
  {
    MySqlConnection database;

    public bool updateFiles(BackgroundWorker myWorker)
    {
      string currentDirectory = Directory.GetCurrentDirectory();
      int progressBarPercent = 0;
      string[] fileNamesArray = { "MapleChord.exe", "Base.wz", "Character.wz", "Effect.wz", "Etc.wz", "Item.wz", "List.wz", "Map.wz", "Mob.wz", "Morph.wz", "Npc.wz", "Quest.wz", "Reactor.wz", "Skill.wz", "Sound.wz", "String.wz", "TamingMob.wz", "UI.wz" };
      string[] MD5Array;
      string[] address;
      try
      {
        // Removed for security
        string connectionString = string.Format("");
        database = new MySqlConnection(connectionString);
        MD5Array = GetData("currentver");
        progressBarPercent = 10;
        myWorker.ReportProgress(progressBarPercent, "Connecting to server...");
        address = GetData("dlinks");
        progressBarPercent += 10;
        myWorker.ReportProgress(progressBarPercent, "Connecting to server...");

        string currentFile;
        string MD5;
        int index = 0;

        // Checks every file in the fileNameArray that was initiated before
        foreach (string fileName in fileNamesArray)
        {
          progressBarPercent += 2;
          myWorker.ReportProgress(progressBarPercent, "Checking " + fileName);
          currentFile = currentDirectory + "\\" + fileName;

          // If the file exists, check MD5, if it fails, delete and download, if it doesn't exist, download
          if (File.Exists(currentFile))
          {
            MD5 = CalculateMD5(currentFile);
            if (MD5 != MD5Array[index])
            {
              File.Delete(currentFile);
              myWorker.ReportProgress(progressBarPercent, "Updating " + fileName);
              DownloadFile(address[0], fileName, currentFile);
            }
          }
          else
          {
            myWorker.ReportProgress(progressBarPercent, "Downloading " + fileName);
            DownloadFile(address[0], fileName, currentFile);
          }
          index++;
        }
        // End of update, set progress bar to 100%
        myWorker.ReportProgress(100, "Complete");
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    // Calculates the MD5Hash of the file specified
    private string CalculateMD5(string fileName)
    {
      using (var md5 = MD5.Create())
      {
        using (var stream = File.OpenRead(fileName))
        {
          var hash = md5.ComputeHash(stream);
          return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
      }
    }

    // Creates a new Web Client and downloads the necesary file into the Current Directory
    private void DownloadFile(string address, string fileName, string currentDirectory)
    {
      using (var client = new WebClient())
      {
        client.DownloadFile(address + fileName, currentDirectory);
      }
    }

    // Gets the entire first row and returns them in a string Array
    private string[] GetData(string table)
    {
      int index;
      int count;
      database.Open();
      MySqlCommand command = new MySqlCommand("SELECT * FROM " + table, database);
      MySqlDataReader dataReader = command.ExecuteReader();
      dataReader.Read();

      // Gets amount of values
      count = dataReader.VisibleFieldCount;

      // Sets the stringArray to the amount of values
      string[] stringArray = new string[count];
      for (index = 0; index < count; index++)
      {
        stringArray[index] = dataReader.GetValue(index).ToString();
      }
      database.Close();
      return stringArray;
    }
  }
}
