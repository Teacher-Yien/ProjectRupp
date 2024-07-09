using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shcool_management
{
	public partial class Login : Form
	{
		private readonly string connectionString = "Data Source=DESKTOP-T1JML11;Initial Catalog=dboStudentManagement;Integrated Security=True;Encrypt=False";  // Replace with your actual connection string

		public Login()
		{
			InitializeComponent();
			password_txt.PasswordChar = '*'; // Hide password characters
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = username_txt.Text;
			string password = password_txt.Text;

			if (ValidateUser(username, password))
			{
				DialogResult = DialogResult.OK; // Set login result to OK
				Close(); // Close the login form
			}
			else
			{
				MessageBox.Show("Invalid username or password");
			}
		}

		private bool ValidateUser(string username, string password)
		{
			// Perform user authentication against the database
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string query = "SELECT COUNT(*) FROM tbUser WHERE UserName = @username AND Userpass = @password";
				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password);

					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}

		private void exit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
