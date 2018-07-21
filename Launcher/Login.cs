using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Launcher
{
  class Login
  {
    public bool verifyLogin(string username, string password)
    {
      // Removed for security
      MySqlConnection database = new MySqlConnection("");

      database.Open();

      // Sets command to get the "password" column value from the table "accounts" where the column "name" = username
      MySqlCommand command = new MySqlCommand("SELECT password FROM accounts where name=@username", database);

      // Sets "@username" where it is used in the command string
      command.Parameters.AddWithValue("@username", username);
      MySqlDataReader dataReader = command.ExecuteReader();
      dataReader.Read();
      if (password == dataReader.GetValue(0).ToString())
      {
        return true;
      }

      MessageBox.Show("Username and/or Password was incorrect.");
      return false;
    }
  }
}
