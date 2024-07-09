using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shcool_management
{
    public partial class Students : Form
    {
		Connection obj = new Connection();
        public Students()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
		}
		private bool ValidateInputs()
		{
			if (string.IsNullOrWhiteSpace(txtStuNameEN.Text))
			{
				MessageBox.Show("Please enter Student Name (English).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			// Add more validation logic for other required fields

			return true;
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs())
			{
				return; // Exit if validation fails
			}

			string connectionString = obj.Connect; // Replace with your connection string

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					string sqlInsert = @"
                INSERT INTO dbo.tbStudent 
                (StuName, StuNameKH, Gender, DateOfBirth, BirthPlace, Email, Year, IsScholarship, ScholarshipPercent, Address, PhoneNumber, FatherName, MotherName, EmergencyContact, PriSchoolName, PriSchoolPeriod, SecSchoolName, SecSchoolPeriod, HighSchoolName, HighSchoolPeriod)
                VALUES 
                (@StuName, @StuNameKH, @Gender, @DateOfBirth, @BirthPlace, @Email, @Year, @IsScholarship, @ScholarshipPercent, @Address, @PhoneNumber, @FatherName, @MotherName, @EmergencyContact, @PriSchoolName, @PriSchoolPeriod, @SecSchoolName, @SecSchoolPeriod, @HighSchoolName, @HighSchoolPeriod)";

					using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
					{
						// Set parameters with appropriate data types
						cmd.Parameters.AddWithValue("@StuName", txtStuNameEN.Text);
						cmd.Parameters.AddWithValue("@StuNameKH", txtStuNameKH.Text);
						cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
						cmd.Parameters.AddWithValue("@DateOfBirth", dtpStu.Value);
						cmd.Parameters.AddWithValue("@BirthPlace", txtBirthPlace.Text);
						cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
						cmd.Parameters.AddWithValue("@Year", txtYear.Text);
						cmd.Parameters.AddWithValue("@IsScholarship", checkScholarship.Checked ? 1 : 0); // Example assuming IsScholarship is a checkbox
						cmd.Parameters.AddWithValue("@ScholarshipPercent", txtPers.Text);
						cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
						cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
						cmd.Parameters.AddWithValue("@FatherName", txtFather.Text);
						cmd.Parameters.AddWithValue("@MotherName", txtMother.Text);
						cmd.Parameters.AddWithValue("@EmergencyContact", txtContact.Text);
						cmd.Parameters.AddWithValue("@PriSchoolName", txtPriSchool.Text);
						cmd.Parameters.AddWithValue("@PriSchoolPeriod", txtPriPer.Text);
						cmd.Parameters.AddWithValue("@SecSchoolName", txtSecSchool.Text);
						cmd.Parameters.AddWithValue("@SecSchoolPeriod", txtSecPer.Text);
						cmd.Parameters.AddWithValue("@HighSchoolName", txtHighSchool.Text);
						cmd.Parameters.AddWithValue("@HighSchoolPeriod", txtHighPer.Text);

						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Student information inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							// Optionally clear input fields or update UI
						}
						else
						{
							MessageBox.Show("No rows inserted. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (SqlException ex)
				{
					MessageBox.Show("An error occurred while inserting student information. Details: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					// Log ex.ToString() for further analysis
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					// Log ex.ToString() for further analysis
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Validate inputs if necessary
			if (!ValidateInputs())
			{
				return; // Exit if validation fails
			}

			string connectionString = obj.Connect; // Replace with your connection string

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					string sqlUpdate = @"
                UPDATE dbo.tbStudent 
                SET StuName = @StuName, 
                    StuNameKH = @StuNameKH, 
                    Gender = @Gender, 
                    DateOfBirth = @DateOfBirth, 
                    BirthPlace = @BirthPlace, 
                    Email = @Email, 
                    Year = @Year, 
                    IsScholarship = @IsScholarship, 
                    ScholarshipPercent = @ScholarshipPercent, 
                    Address = @Address, 
                    PhoneNumber = @PhoneNumber, 
                    FatherName = @FatherName, 
                    MotherName = @MotherName, 
                    EmergencyContact = @EmergencyContact, 
                    PriSchoolName = @PriSchoolName, 
                    PriSchoolPeriod = @PriSchoolPeriod, 
                    SecSchoolName = @SecSchoolName, 
                    SecSchoolPeriod = @SecSchoolPeriod, 
                    HighSchoolName = @HighSchoolName, 
                    HighSchoolPeriod = @HighSchoolPeriod
                WHERE StudentID = @StudentID";

					using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
					{
						// Set parameters with appropriate data types
						cmd.Parameters.AddWithValue("@StuName", txtStuNameEN.Text);
						cmd.Parameters.AddWithValue("@StuNameKH", txtStuNameKH.Text);
						cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
						cmd.Parameters.AddWithValue("@DateOfBirth", dtpStu.Value);
						cmd.Parameters.AddWithValue("@BirthPlace", txtBirthPlace.Text);
						cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
						cmd.Parameters.AddWithValue("@Year", txtYear.Text);
						cmd.Parameters.AddWithValue("@IsScholarship", checkScholarship.Checked ? 1 : 0); // Example assuming IsScholarship is a checkbox
						cmd.Parameters.AddWithValue("@ScholarshipPercent", txtPers.Text);
						cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
						cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
						cmd.Parameters.AddWithValue("@FatherName", txtFather.Text);
						cmd.Parameters.AddWithValue("@MotherName", txtMother.Text);
						cmd.Parameters.AddWithValue("@EmergencyContact", txtContact.Text);
						cmd.Parameters.AddWithValue("@PriSchoolName", txtPriSchool.Text);
						cmd.Parameters.AddWithValue("@PriSchoolPeriod", txtPriPer.Text);
						cmd.Parameters.AddWithValue("@SecSchoolName", txtSecSchool.Text);
						cmd.Parameters.AddWithValue("@SecSchoolPeriod", txtSecPer.Text);
						cmd.Parameters.AddWithValue("@HighSchoolName", txtHighSchool.Text);
						cmd.Parameters.AddWithValue("@HighSchoolPeriod", txtHighPer.Text);

						// Assuming you have a StudentID to uniquely identify the record to update
						cmd.Parameters.AddWithValue("@StudentID", txtStuID); // Replace with the actual StudentID from your application logic

						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							// Optionally clear input fields or update UI
						}
						else
						{
							MessageBox.Show("No rows updated. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (SqlException ex)
				{
					MessageBox.Show("An error occurred while updating student information. Details: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					// Log ex.ToString() for further analysis
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					// Log ex.ToString() for further analysis
				}
			}
		}


		private void ClearUIFields()
		{
			// Clear textboxes
			txtStuID.Text = string.Empty;
			txtStuNameEN.Text = string.Empty;
			txtStuNameKH.Text = string.Empty;
			txtBirthPlace.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtYear.Text = string.Empty;
			txtPers.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtPhone.Text = string.Empty;
			txtFather.Text = string.Empty;
			txtMother.Text = string.Empty;
			txtContact.Text = string.Empty;
			txtPriSchool.Text = string.Empty;
			txtPriPer.Text = string.Empty;
			txtSecSchool.Text = string.Empty;
			txtSecPer.Text = string.Empty;
			txtHighSchool.Text = string.Empty;
			txtHighPer.Text = string.Empty;

			// Clear comboboxes
			cboGender.SelectedIndex = -1; // or set to default value
			checkScholarship.Checked = false; // or set to default value

			// Clear datetime picker
			dtpStu.Value = DateTime.Now; // or set to default date

			// Additional UI elements to clear as needed

			// Example for checkboxes
			// checkBox1.Checked = false;

			// Example for listboxes
			// listBox1.ClearSelected();

			// Example for picture boxes
			// pictureBox1.Image = null;

			// Handle any other UI elements in your form
		}


		private void lstStu_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstStu.SelectedItems != null && lstStu.SelectedItems.Count > 0)
			{
				foreach (var selectedItem in lstStu.SelectedItems)
				{
					string selectedStaffName = selectedItem.ToString();

					using (SqlConnection connection = new SqlConnection(obj.Connect))
					{
						try
						{
							connection.Open();

							string query = "SELECT * FROM tbStudent WHERE StuName = @StuName";

							using (SqlCommand command = new SqlCommand(query, connection))
							{
								command.Parameters.AddWithValue("@StuName", selectedStaffName);

								using (SqlDataReader reader = command.ExecuteReader())
								{
									if (reader.Read())
									{
										// Populate UI elements with student data
										txtStuID.Text = reader["StuID"].ToString();
										txtStuNameEN.Text = reader["StuName"].ToString();
										txtStuNameKH.Text = reader["StuNameKH"].ToString();
										cboGender.Text = reader["Gender"].ToString();
										dtpStu.Value = Convert.ToDateTime(reader["DateOfBirth"]);
										txtBirthPlace.Text = reader["BirthPlace"].ToString();
										txtEmail.Text = reader["Email"].ToString();
										txtYear.Text = reader["Year"].ToString();
										checkScholarship.Checked = Convert.ToBoolean(reader["IsScholarship"]);
										txtPers.Text = reader["ScholarshipPercent"].ToString();
										txtAddress.Text = reader["Address"].ToString();
										txtPhone.Text = reader["PhoneNumber"].ToString();
										txtFather.Text = reader["FatherName"].ToString();
										txtMother.Text = reader["MotherName"].ToString();
										txtContact.Text = reader["EmergencyContact"].ToString();
										txtPriSchool.Text = reader["PriSchoolName"].ToString();
										txtPriPer.Text = reader["PriSchoolPeriod"].ToString();
										txtSecSchool.Text = reader["SecSchoolName"].ToString();
										txtSecPer.Text = reader["SecSchoolPeriod"].ToString();
										txtHighSchool.Text = reader["HighSchoolName"].ToString();
										txtHighPer.Text = reader["HighSchoolPeriod"].ToString();
									}
									else
									{
										MessageBox.Show($"No student found associated with staff member: {selectedStaffName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}
						catch (SqlException ex)
						{
							MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				// Clear UI elements if no staff member is selected
				ClearUIFields(); // Implement this method to clear all relevant UI controls
			}
		}


		private void Students_Load(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(obj.Connect))
				{
					conn.Open();

					using (SqlCommand cmd = new SqlCommand("dbo.spStudent", conn)) // Assuming dbo.spStudents is your stored procedure for students
					{
						cmd.CommandType = CommandType.StoredProcedure;

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								while (reader.Read())
								{
									string studentName = reader["StuName"].ToString(); // Adjust column name as per your schema
																					   // Do something with the retrieved student data, such as displaying it in a ListBox
									lstStu.Items.Add(studentName);
								}
							}
						}
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void RefreshStudentList()
		{
			lstStu.Items.Clear(); // Clear existing items

			// Re-populate the list with updated student information
			using (SqlConnection conn = new SqlConnection(obj.Connect))
			{
				string sqlQuery = "SELECT StuName FROM tbStudent ORDER BY StuName"; // Example query to retrieve student names

				using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						string studentName = reader["StuName"].ToString();
						lstStu.Items.Add(studentName);
					}
					reader.Close();
				}
			}
		}


		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			string searchText = txtSearch.Text.Trim();

			// Clear existing items in the list
			lstStu.Items.Clear();

			// Ensure the search text is not empty
			if (!string.IsNullOrEmpty(searchText))
			{
				// Establish connection to the database
				using (SqlConnection conn = new SqlConnection(obj.Connect))
				{
					// SQL query to retrieve student names that start with the search text
					string sqlQuery = "SELECT StuName FROM tbStudent WHERE StuName LIKE @SearchText + '%' ORDER BY StuName";

					// Create SqlCommand object with parameterized query
					using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
					{
						// Add parameter to the query
						cmd.Parameters.AddWithValue("@SearchText", searchText);

						try
						{
							// Open the database connection
							conn.Open();

							// Execute the query and retrieve results
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								// Iterate through the result set
								while (reader.Read())
								{
									// Read student name from the result set
									string studentName = reader["StuName"].ToString();

									// Add student name to the ListBox
									lstStu.Items.Add(studentName);
								}
							}
						}
						catch (SqlException ex)
						{
							// Handle SQL exception (database error)
							MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							// Handle other exceptions
							MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				// If search text is empty, refresh the list to show all students
				RefreshStudentList();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Check if a student is selected in the ListBox (lstStu), assuming lstStu is your ListBox containing student names
			if (lstStu.SelectedIndex != -1)
			{
				// Retrieve the selected student name
				string selectedStudentName = lstStu.SelectedItem.ToString();

				// Confirmation dialog to ensure the user wants to delete the student
				DialogResult result = MessageBox.Show($"Are you sure you want to delete the student '{selectedStudentName}'?",
													   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					// Delete the student from the database
					using (SqlConnection conn = new SqlConnection(obj.Connect))
					{
						try
						{
							conn.Open();

							// SQL query to delete student by name
							string sqlDelete = "DELETE FROM tbStudent WHERE StuName = @StuName";

							using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
							{
								// Add parameter for student name
								cmd.Parameters.AddWithValue("@StuName", selectedStudentName);

								// Execute the query
								int rowsAffected = cmd.ExecuteNonQuery();

								if (rowsAffected > 0)
								{
									MessageBox.Show($"Student '{selectedStudentName}' deleted successfully.", "Success",
													MessageBoxButtons.OK, MessageBoxIcon.Information);

									// Optionally clear UI fields or update list/grid after deletion
									ClearUIFields(); // Example function to clear fields
									RefreshStudentList(); // Example function to refresh student list
								}
								else
								{
									MessageBox.Show($"No student found with the name '{selectedStudentName}'.", "Information",
													MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
						catch (SqlException ex)
						{
							MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Please select a student to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
