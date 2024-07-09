using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shcool_management
{
 
	public partial class Staff : Form
    {
		Connection obj = new Connection();
		string imagePath ;
		

		public Staff()
        {
            InitializeComponent();
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

public static byte[] ResizeImage(string imagePath, int maxWidth, int maxHeight)
	{
		byte[] imageData = null;

		try
		{
			using (Image img = Image.FromFile(imagePath))
			{
				int width = img.Width;
				int height = img.Height;

				// Calculate new dimensions
				if (width > maxWidth || height > maxHeight)
				{
					double ratio = Math.Min((double)maxWidth / width, (double)maxHeight / height);
					width = (int)(width * ratio);
					height = (int)(height * ratio);
				}

				// Create resized image
				using (Bitmap newImg = new Bitmap(width, height))
				{
					using (Graphics gr = Graphics.FromImage(newImg))
					{
						gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
						gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
						gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
						gr.DrawImage(img, new Rectangle(0, 0, width, height));
					}

					// Convert resized image to byte array
					using (MemoryStream ms = new MemoryStream())
					{
						newImg.Save(ms, ImageFormat.Jpeg); // Change ImageFormat as per your requirement
						imageData = ms.ToArray();
					}
				}
			}
		}
		catch (Exception ex)
		{
			// Handle exceptions or log them as necessary
			Console.WriteLine("Error resizing image: " + ex.Message);
		}

		return imageData;
	}




		private void btnInsert_Click(object sender, EventArgs e)
		{
			try
			{
				// Ensure imagePath is initialized properly elsewhere in your class
				if (string.IsNullOrEmpty(imagePath))
				{
					MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Resize image and get image data
				byte[] imageData = ResizeImage(imagePath, maxWidth: 300, maxHeight: 200);

				Console.WriteLine();

				using (SqlConnection conn = new SqlConnection(obj.Connect))
				{
					conn.Open();

					string sqlInsert = @"
                INSERT INTO tbStaff 
                (StaffName, StaffNameKH, Gender, StaffDOB, StaffEmail, StaffAddress, StaffPosition, StaffType, Ethinicity, MarriageStatus, Status, Qualification, PhoneNumber, EmergencyContact, HireDate, PictureN) 
                VALUES 
                (@StaffNameEN, @StaffNameKH, @Gender, @StaffDOB, @StaffEmail, @StaffAddress, @StaffPosition, @StaffType, @Ethinicity, @MarriageStatus, @Status, @Qualification, @PhoneNumber, @EmergencyContact, @HireDate, @Picture)";

					using (SqlCommand cmd = new SqlCommand(sqlInsert, conn))
					{
						// Get data from UI elements (assuming proper validation)
						string staffNameEN = txtStaffNameEN.Text;
						string staffNameKH = txtStaffNameKH.Text;
						string gender = cboGender.Text;
						DateTime dobAsDate = dtpStaff.Value;
						string staffEmail = txtStaffEmail.Text;
						string staffAddress = txtStaffAddress.Text;
						string position = txtPosition.Text;
						string staffType = txtStaffType.Text;
						string ethnicity = txtStaffEth.Text;
						string mStatus = radioBtnSingular.Checked ? radioBtnSingular.Text : radioBtnMarried.Text;
						bool status = checkStaffStatus.Checked; // Assuming checkbox reflects boolean value
						string qualification = cboQualification.Text;
						string phoneNumber = txtStaffPhone.Text;
						string emergencyContact = txtStaffPhoneEmergency.Text;
						DateTime hireDateAsDate = dtpHiredDate.Value;
						byte[] img = File.ReadAllBytes(imagePath);

						// Add parameters with appropriate data types
						cmd.Parameters.AddWithValue("@StaffNameEN", staffNameEN);
						cmd.Parameters.AddWithValue("@StaffNameKH", staffNameKH);
						cmd.Parameters.AddWithValue("@Gender", gender);
						cmd.Parameters.AddWithValue("@StaffDOB", dobAsDate);
						cmd.Parameters.AddWithValue("@StaffEmail", staffEmail);
						cmd.Parameters.AddWithValue("@StaffAddress", staffAddress);
						cmd.Parameters.AddWithValue("@StaffPosition", position);
						cmd.Parameters.AddWithValue("@StaffType", staffType);
						cmd.Parameters.AddWithValue("@Ethinicity", ethnicity);
						cmd.Parameters.AddWithValue("@MarriageStatus", mStatus);
						cmd.Parameters.AddWithValue("@Status", status);
						cmd.Parameters.AddWithValue("@Picture", img); // Insert image data
						cmd.Parameters.AddWithValue("@Qualification", qualification);
						cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
						cmd.Parameters.AddWithValue("@EmergencyContact", emergencyContact);
						cmd.Parameters.AddWithValue("@HireDate", hireDateAsDate);

						// Execute the SQL command
						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Staff information inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							lstStaff.Items.Add(staffNameEN); // Assuming lstStaff is a ListBox where you want to add the new staff name
						}
						else
						{
							MessageBox.Show("No rows inserted. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (SqlException ex)
			{
				// Log SQL errors
				MessageBox.Show("SQL Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				// Log other unexpected errors
				MessageBox.Show("Unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		private void RefreshStaffList()
		{
			lstStaff.Items.Clear(); // Clear existing items

			// Re-populate the list with updated staff information
			using (SqlConnection conn = new SqlConnection(obj.Connect))
			{
				string sqlQuery = "SELECT StaffName FROM tbStaff ORDER BY StaffName"; // Example query to retrieve staff names

				using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
				{
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						string staffName = reader["StaffName"].ToString();
						lstStaff.Items.Add(staffName);
					}
					reader.Close();
				}
			}
		}
		private void Staff_Load(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(obj.Connect))
			{
				conn.Open();

				using (SqlCommand cmd = new SqlCommand("dbo.spStaff", conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.HasRows)
						{
							while (reader.Read())
							{
								string staffName = reader["StaffName"].ToString(); // Replace "StaffName" with the actual column name
																				   // Do something with the retrieved data, such as displaying it in a ListBox
								lstStaff.Items.Add(staffName);
							}
						}
					}
				}
			}
		}




		/*private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			string searchText = txtSearch.Text.Trim();
			lstStu.Items.Clear(); // Clear previous search results

			try
			{
				// Database connection and query execution
				using (var connection = new SqlConnection(obj.Connect))
				{
					connection.Open();

					string query = "select * from dbo.fnSearchtbStaffbyNameKH(@StaffName)";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@StaffName", "%" + searchText + "%");

						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								string staffName = reader["StaffNameKH"].ToString();
								lstStu.Items.Add(staffName); // Add search result to the ListBox
							}
						}
					}

					lstStu.Refresh(); // Ensure visual update of the ListBox
				}

				if (lstStu.Items.Count == 0 && !string.IsNullOrEmpty(searchText))
				{
					MessageBox.Show("No staff names matching '" + searchText + "' were found.");
				}
			}
			catch (SqlException ex) // Handle database-related errors
			{
				// Log the exception details (connection string, query, etc.)
				Console.WriteLine("An error occurred during the search: " + ex.Message);
			}
			catch (NullReferenceException ex) // Handle potential null reference exceptions
			{
				// Log the exception details (variable name, stack trace)
				Console.WriteLine("An unexpected error occurred: " + ex.Message);
			}
		}*/

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			string searchText = txtSearch.Text.Trim();

			// Assuming you want to filter a list or grid (example with ListBox)
			lstStaff.Items.Clear(); // Clear existing items

			using (SqlConnection conn = new SqlConnection(obj.Connect))
			{
				string sqlQuery = "SELECT StaffName FROM tbStaff WHERE StaffName LIKE @SearchText + '%' ORDER BY StaffName";

				using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
				{
					cmd.Parameters.AddWithValue("@SearchText", searchText);
					conn.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						string staffName = reader["StaffName"].ToString();
						lstStaff.Items.Add(staffName);
					}
					reader.Close();
				}
			}
		}


		private void lstStaff_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			//MessageBox.Show("Success");
			if (lstStaff.SelectedItems != null)
			{

				foreach (var selectedItem in lstStaff.SelectedItems)
				{
					string selectedStaffName = selectedItem.ToString();

					using (SqlConnection connection = new SqlConnection(obj.Connect))
					{
						try
						{
							connection.Open();

							string query = "SELECT * FROM tbStaff WHERE StaffName = @StaffName";

							using (SqlCommand command = new SqlCommand(query, connection))
							{
								command.Parameters.AddWithValue("@StaffName", selectedStaffName);

								using (SqlDataReader reader = command.ExecuteReader())
								{
									if (reader.Read())
									{
										// Update textboxes for each selected staff member
										txtStaffID.Text = reader["StaffID"].ToString();
										txtStaffNameEN.Text = reader["StaffName"].ToString();
										txtStaffNameKH.Text = reader["StaffNameKH"].ToString();
										cboGender.Text = reader["Gender"].ToString();
										dtpStaff.Value = reader["StaffDOB"] != DBNull.Value ? Convert.ToDateTime(reader["StaffDOB"]) : DateTime.MinValue;
										txtStaffEmail.Text = reader["StaffEmail"].ToString();
										txtStaffAddress.Text = reader["StaffAddress"].ToString();
										txtPosition.Text = reader["StaffPosition"].ToString();
										txtStaffType.Text = reader["StaffType"].ToString();
										txtStaffEth.Text = reader["Ethinicity"].ToString();
										string mStatus = reader["MarriageStatus"].ToString();
										if (radioBtnSingular.Checked) mStatus = radioBtnSingular.Text;
										else mStatus = radioBtnMarried.Text;
										cboQualification.Text = reader["Qualification"].ToString();
										txtStaffPhone.Text = reader["PhoneNumber"].ToString();
										txtStaffPhoneEmergency.Text = reader["EmergencyContact"].ToString();
										dtpHiredDate.Value = reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : DateTime.MinValue;

										// Handle DBNull for Picture and Status
										txtImagePath.Text = reader["Picture"] != DBNull.Value ? reader["Picture"].ToString() : string.Empty;
										checkStaffStatus.Text = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "N/A";
									}
									else
									{
										MessageBox.Show($"No staff member found with the name: {selectedStaffName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
							}
						}
						catch (SqlException ex)
						{
							// LogException(ex);
							MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						catch (Exception ex)
						{
							// LogException(ex);
							MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(obj.Connect))
			{
				try
				{
					conn.Open();

					string sqlUpdate = @"
                UPDATE tbStaff SET 
                    StaffName = @StaffNameEN,
                    StaffNameKH = @StaffNameKH,
                    Gender = @Gender,
                    StaffDOB = @StaffDOB,
                    StaffEmail = @StaffEmail,
                    StaffAddress = @StaffAddress,
                    StaffPosition = @StaffPosition,
                    StaffType = @StaffType,
                    Ethinicity = @Ethinicity,
                    MarriageStatus = @MarriageStatus,
                    Status = @Status,
                    Qualification = @Qualification,
                    PhoneNumber = @PhoneNumber,
                    EmergencyContact = @EmergencyContact,
                    HireDate = @HireDate,
                    PictureN = @Picture
                WHERE StaffID = @StaffID";

					using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
					{
						// Get data from UI elements (assuming proper validation)
						string staffID = txtStaffID.Text; // Assuming StaffID is not an identity column
						string staffNameEN = txtStaffNameEN.Text;
						string staffNameKH = txtStaffNameKH.Text;
						string gender = cboGender.Text;
						DateTime dobAsDate = dtpStaff.Value;
						string staffEmail = txtStaffEmail.Text;
						string staffAddress = txtStaffAddress.Text;
						string position = txtPosition.Text;
						string staffType = txtStaffType.Text;
						string ethnicity = txtStaffEth.Text;
						string mStatus = radioBtnSingular.Checked ? radioBtnSingular.Text : radioBtnMarried.Text;
						bool status = checkStaffStatus.Checked; // Assuming checkbox reflects boolean value
						string pictureData = imagePath; // Replace with your method to get image as byte array
						string qualification = cboQualification.Text;
						string phoneNumber = txtStaffPhone.Text;
						string emergencyContact = txtStaffPhoneEmergency.Text;
						DateTime hireDateAsDate = dtpHiredDate.Value;

						// Add parameters with appropriate data types
						cmd.Parameters.AddWithValue("@StaffID", staffID); // Include StaffID if it's not an identity column
						cmd.Parameters.AddWithValue("@StaffNameEN", staffNameEN);
						cmd.Parameters.AddWithValue("@StaffNameKH", staffNameKH);
						cmd.Parameters.AddWithValue("@Gender", gender);
						cmd.Parameters.AddWithValue("@StaffDOB", dobAsDate);
						cmd.Parameters.AddWithValue("@StaffEmail", staffEmail);
						cmd.Parameters.AddWithValue("@StaffAddress", staffAddress);
						cmd.Parameters.AddWithValue("@StaffPosition", position);
						cmd.Parameters.AddWithValue("@StaffType", staffType);
						cmd.Parameters.AddWithValue("@Ethinicity", ethnicity);
						cmd.Parameters.AddWithValue("@MarriageStatus", mStatus);
						cmd.Parameters.AddWithValue("@Status", status);

						// Handle picture data
						if (pictureData != null && pictureData.Length > 0)
						{
							cmd.Parameters.AddWithValue("@Picture", pictureData);
						}
						else
						{
							cmd.Parameters.AddWithValue("@Picture", DBNull.Value);
						}

						cmd.Parameters.AddWithValue("@Qualification", qualification);
						cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
						cmd.Parameters.AddWithValue("@EmergencyContact", emergencyContact);
						cmd.Parameters.AddWithValue("@HireDate", hireDateAsDate);

						// Execute the SQL command
						int rowsAffected = cmd.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							MessageBox.Show("Staff information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
							// Optionally update the list or grid where staff information is displayed
							// UpdateListOrGrid(staffID, staffNameEN); // Example function to update UI
						}
						else
						{
							MessageBox.Show("No rows updated. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch (SqlException ex)
				{
					// Log the exception details for further analysis
					MessageBox.Show("An error occurred while updating staff information. Details: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					// Handle any other unexpected exceptions
					MessageBox.Show("Unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Assuming txtStaffID contains the ID of the staff member to be deleted
			string staffID = txtStaffID.Text.Trim();

			if (string.IsNullOrEmpty(staffID))
			{
				MessageBox.Show("Please enter Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Confirm deletion with user
			DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Proceed with deletion
				using (SqlConnection conn = new SqlConnection(obj.Connect))
				{
					try
					{
						conn.Open();

						string sqlDelete = "DELETE FROM tbStaff WHERE StaffID = @StaffID";

						using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
						{
							// Add parameter for StaffID
							cmd.Parameters.AddWithValue("@StaffID", staffID);

							// Execute the SQL command
							int rowsAffected = cmd.ExecuteNonQuery();

							if (rowsAffected > 0)
							{
								MessageBox.Show("Staff information deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

								// Optionally clear UI fields or update list/grid after deletion
								ClearUIFields(); // Example function to clear fields
								RefreshStaffList(); // Example function to refresh staff list
							}
							else
							{
								MessageBox.Show("No rows deleted. Please check the Staff ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
					catch (SqlException ex)
					{
						// Log the exception details for further analysis
						MessageBox.Show("An error occurred while deleting staff information. Details: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						// Handle any other unexpected exceptions
						MessageBox.Show("Unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		

		private void ClearUIFields()
		{
			txtStaffID.Text = "";
			txtStaffNameEN.Text = "";
			txtStaffNameKH.Text = "";
			cboGender.SelectedIndex = -1; // Assuming cboGender is a ComboBox for gender selection
			dtpStaff.Value = DateTime.Today;
			txtStaffEmail.Text = "";
			txtStaffAddress.Text = "";
			txtPosition.Text = "";
			txtStaffType.Text = "";
			txtStaffEth.Text = "";
			radioBtnSingular.Checked = false;
			radioBtnMarried.Checked = false;
			checkStaffStatus.Checked = false;
			// Clear other fields as needed
		}

		private void btnBrowserImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Select Image File";
				openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All Files (*.*)|*.*";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Get the selected file's path
					imagePath = openFileDialog.FileName;

					// Display the selected image path in a TextBox or Label, or set it to an Image control
					txtImagePath.Text = imagePath; // Example: display the path in a TextBox named txtImagePath

					// Optionally, load and display the selected image preview in an Image control
					try
					{
						Image selectedImage = Image.FromFile(imagePath);
						picStaff.Image = selectedImage; // Example: display in a PictureBox named picStaff
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}















		/*		private void lstStu_MouseClick(object sender, MouseEventArgs e)
				{

					if (lstStu.SelectedItem != null)
					{
						string selectedStaffName = lstStu.SelectedItem.ToString();

						using (SqlConnection connection = new SqlConnection(obj.Connect))
						{
							try
							{
								connection.Open();

								string query = "SELECT * FROM dbo.vStaffName WHERE StaffName = @StaffName";

								using (SqlCommand command = new SqlCommand(query, connection))
								{
									command.Parameters.AddWithValue("@StaffName", selectedStaffName);

									using (SqlDataReader reader = command.ExecuteReader())
									{
										if (reader.Read())
										{
											// Populate UI controls with the retrieved data
											txtStaffID.Text = reader["StaffID"].ToString();
											txtStaffNameEN.Text = reader["StaffName"].ToString();
											txtStaffNameKH.Text = reader["StaffNameKH"].ToString();
											cboGender.Text = reader["Gender"].ToString();
											dtpStaff.Value = reader["StaffDOB"] != DBNull.Value ? Convert.ToDateTime(reader["StaffDOB"]) : DateTime.MinValue;
											txtStaffEmail.Text = reader["StaffEmail"].ToString();
											txtStaffAddress.Text = reader["StaffAddress"].ToString();
											txtPosition.Text = reader["StaffPosition"].ToString();
											txtStaffType.Text = reader["StaffType"].ToString();
											txtStaffEth.Text = reader["Ethinicity"].ToString();
											cboQualification.Text = reader["Qualification"].ToString();
											txtStaffPhone.Text = reader["PhoneNumber"].ToString();
											txtStaffPhoneEmergency.Text = reader["EmergencyContact"].ToString();
											dtpHiredDate.Value = reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : DateTime.MinValue;

											// Handle DBNull for Picture and Status
											picStaff.Text = reader["Picture"] != DBNull.Value ? reader["Picture"].ToString() : string.Empty;
											checkStaffStatus.Text = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "N/A";
										}
										else
										{
											MessageBox.Show("No staff member found with the selected name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
										}
									}
								}
							}
							catch (SqlException ex)
							{
								//LogException(ex);
								MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							catch (Exception ex)
							{
								//LogException(ex);
								MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}

				}*/








		// return 0
	}
}
