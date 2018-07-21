using System;
using System.Windows.Forms;

namespace Launcher
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // If there is a saved username in the property setting, set the username and password boxes
      if (Properties.Settings.Default.Username != string.Empty)
      {
        usernameBox.Text = Properties.Settings.Default.Username;
        passwordBox.Text = Properties.Settings.Default.Password;
      }
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      Login newLogin = new Login();

      // If the login credentials are correct then it checks if "remember me" is checked and creates the new form
      if (newLogin.verifyLogin(usernameBox.Text, passwordBox.Text))
      {
        // If checked, saves the username and password entered in the property settings
        if (rememberBox.Checked)
        {
          Properties.Settings.Default.Username = usernameBox.Text;
          Properties.Settings.Default.Password = passwordBox.Text;
          Properties.Settings.Default.Save();
        }

        // Creates new form and passes username so login can be checked again and for voting
        var form = new Form2(usernameBox.Text, passwordBox.Text);

        // Puts the form location in the same spot on monitor
        form.Location = this.Location;
        form.StartPosition = FormStartPosition.Manual;

        // Makes it so when Form2 is closed, so is Form1
        form.FormClosing += delegate { this.Close(); };

        // Shows new Form, hides old one
        form.Show();
        this.Hide();
      }
    }

    private void loginButton_MouseEnter(object sender, EventArgs e)
    {
      this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
    }

    private void loginButton_MouseLeave(object sender, EventArgs e)
    {
      this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
    }
  }
}

