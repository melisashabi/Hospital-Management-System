using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
   

            // Placeholder setup
            SetPlaceholder(txtName, "e.g John Smith");
            SetPlaceholder(txtAge, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition, "e.g Flu");
            SetPlaceholder(txtSearchbar2, "Search records...");
        }

        // ---------- Placeholder helper ----------
        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // ---------- Doctors button click ----------
        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            Form doctorsWindow = new Form();
            doctorsWindow.Text = "Doctors Management";
            doctorsWindow.StartPosition = FormStartPosition.CenterScreen;
            doctorsWindow.Size = new Size(1000, 700);

            DoctorsControl doctorsControl = new DoctorsControl();
            doctorsControl.TopLevel = false;   // 🔥 THIS LINE FIXES IT
            doctorsControl.FormBorderStyle = FormBorderStyle.None;
            doctorsControl.Dock = DockStyle.Fill;

            doctorsWindow.Controls.Add(doctorsControl);
            doctorsControl.Show();              // IMPORTANT
            doctorsWindow.Show();

            this.FindForm()?.Hide();
        }



        private void BtnAppointments_Click(object sender, EventArgs e)
        {

            AppointmentsControl appointments = new AppointmentsControl();
            appointments.Show();
        }



        // ---------- Patient saving ----------
        private void button1_Click(object sender, EventArgs e)
        {
            // 🔴 INPUT VALIDATION — GOES HERE (TOP)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Full Name is required.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (cmbGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text) || !txtContact.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid contact number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCondition.Text))
            {
                MessageBox.Show("Condition is required.");
                return;
            }

            if (txtName.ForeColor == Color.Gray)
            {
                MessageBox.Show("Full Name is required.");
                return;
            }

            if (txtCondition.ForeColor == Color.Gray)
            {
                MessageBox.Show("Condition is required.");
                return;
            }



            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "INSERT INTO Patients (Name, Age, Gender, Contact, Condition) VALUES (@Name, @Age, @Gender, @Contact, @Condition)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Condition", txtCondition.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Saved Successfully!");
                    LoadPatients();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ---------- Form load ----------
        private void Form1_Load(object sender, EventArgs e)
        {
            // 🔥 FIX: break data binding
            cmbGender.DataSource = null;

            cmbGender.Items.Clear();
            cmbGender.Items.Add("Select gender");
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbGender.SelectedIndex = 0;

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Standard;

            // 🔥 IMPORTANT FIX
            cmbGender.DrawMode = DrawMode.Normal;

            // dropdown height fix (keep this)
            cmbGender.IntegralHeight = false;
            cmbGender.DropDownHeight = 100;
            

            LoadPatients();



            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                }
                LoadPatients();
            }
            catch (SqlException ex)
            {
                
            }

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtAge_TextChanged(object sender, EventArgs e) { }

        private void txtCondition_TextChanged(object sender, EventArgs e) { }

        private void txtContact_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label1_Click_1(object sender, EventArgs e) { }

        private void label1_Click_2(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label4_Click_1(object sender, EventArgs e) { }

        private void Gender_Click(object sender, EventArgs e) { }

        private void Age_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            // Reset layout safely
            panel1.Visible = false;
            panel1.Visible = true;

            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchbar2_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchbar2.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadPatients(); // show all patients again
            }
            else
            {
                LoadPatientsFiltered(searchText); // filter
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadPatients()
        {
            try
            {
                dgvPatients.DataSource = null;
                dgvPatients.Rows.Clear();
                dgvPatients.Columns.Clear();

                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT Name, Age, Gender, Contact, Condition FROM Patients";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Define columns
                    dgvPatients.Columns.Add("Name", "Full Name");
                    dgvPatients.Columns.Add("Age", "Age");
                    dgvPatients.Columns.Add("Gender", "Gender");
                    dgvPatients.Columns.Add("Contact", "Contact Number");
                    dgvPatients.Columns.Add("Condition", "Condition");

                    while (reader.Read())
                    {
                        dgvPatients.Rows.Add(
                            reader["Name"].ToString(),
                            reader["Age"].ToString(),
                            reader["Gender"].ToString(),
                            reader["Contact"].ToString(),
                            reader["Condition"].ToString()
                        );
                    }

                    dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load patients: " + ex.Message);
            }
        }

        private void LoadPatientsFiltered(string searchText)
        {
            try
            {
                dgvPatients.DataSource = null;
                dgvPatients.Rows.Clear();
                dgvPatients.Columns.Clear();

                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                SELECT Name, Age, Gender, Contact, Condition
                FROM Patients
                WHERE 
                    Name LIKE @search OR
                    Gender LIKE @search OR
                    Contact LIKE @search OR
                    Condition LIKE @search
            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Columns
                    dgvPatients.Columns.Add("Name", "Full Name");
                    dgvPatients.Columns.Add("Age", "Age");
                    dgvPatients.Columns.Add("Gender", "Gender");
                    dgvPatients.Columns.Add("Contact", "Contact Number");
                    dgvPatients.Columns.Add("Condition", "Condition");

                    while (reader.Read())
                    {
                        dgvPatients.Rows.Add(
                            reader["Name"].ToString(),
                            reader["Age"].ToString(),
                            reader["Gender"].ToString(),
                            reader["Contact"].ToString(),
                            reader["Condition"].ToString()
                        );
                    }

                    dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.");
                return;
            }

            // Get contact number from selected row
            string contact = dgvPatients.SelectedRows[0].Cells["Contact"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "DELETE FROM Patients WHERE Contact = @Contact";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Contact", contact);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Patient deleted successfully.");
                LoadPatients(); // refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message);
            }
        }
    }

}
