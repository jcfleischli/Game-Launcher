using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;

namespace Launcher
{
  public partial class Form2 : Form
  {
    private BackgroundWorker myWorker = new BackgroundWorker();
    string username;
    string password;
    bool updated = false;

    public Form2(string username, string password)
    {
      InitializeComponent();
      myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
      myWorker.ProgressChanged += new ProgressChangedEventHandler(myWorker_ProgressChanged);
      myWorker.WorkerReportsProgress = true;
      myWorker.WorkerSupportsCancellation = true;
      this.username = username;
      this.password = password;

      progressBar.Maximum = 100;
      progressBar.Minimum = 0;
    }

    /***********************
    * Form Event Handlers
    ***********************/
    private void Form2_Shown(object sender, EventArgs e)
    {
      // Run myWorker in the background to do updates
      myWorker.RunWorkerAsync();

      if (!(updated))
      {
        MessageBox.Show("There was an error updating the game files.");
        this.Close();
      }
      else
      {
        startButton.Enabled = true;
      }
    }

    /***********************
    * Button Event Handlers
    ***********************/
    private void startButton_Click(object sender, EventArgs e)
    {
      // Still needs: get user macid, ipaddress, update db with it and set loginok = true;

      Login loginCheck = new Login();

      // Checks login credentials with the database
      if (loginCheck.verifyLogin(username, password))
      {
        Process.Start("MapleChord.exe");
      }
      this.Close();
    }

    // Votes...
    private void voteButton_Click(object sender, EventArgs e)
    {
      ProcessStartInfo vote = new ProcessStartInfo("http://www.gtop100.com/topsites/MapleStory/sitedetails/-BRAND-NEW--MapleChord-v62-x8x40-Exp--x1-Mesos--x2-Drop-and-x12x44-Quest-94510?vote=1&pingUsername=" + username);
      Process.Start(vote);
    }

    /*********************************
    * BackgroundWorker Event Handlers
    *********************************/
    void myWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      // Sets the value and text based on what is returned from Update
      progressBar.Value = e.ProgressPercentage;
      statusLabel.Text = e.UserState.ToString() + ": " + progressBar.Value.ToString() + "%";
    }

    void myWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      Update updater = new Update();
      updated = updater.updateFiles(myWorker);
    }

    /**********************
    * Mouse Event Handlers
    **********************/
    private void startButton_MouseEnter(object sender, EventArgs e)
    {
      this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
    }

    private void startButton_MouseLeave(object sender, EventArgs e)
    {
      this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
    }

    private void voteButton_MouseEnter(object sender, EventArgs e)
    {
      this.voteButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
    }

    private void voteButton_MouseLeave(object sender, EventArgs e)
    {
      this.voteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
    }
  } 
}
