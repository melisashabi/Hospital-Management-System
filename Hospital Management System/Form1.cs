using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        private List<Patient> sampleData = new List<Patient>
        {
            new Patient { Id = 1, Name = "Anna", Age = 30, Gender = "Female", Contact = "+1234567890", Condition = "Flu" },
            new Patient { Id = 2, Name = "Mark", Age = 45, Gender = "Male", Contact = "+0987654321", Condition = "Cold" },
            new Patient { Id = 3, Name = "Sarah", Age = 28, Gender = "Female", Contact = "+1122334455", Condition = "Fever" }
        };

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;

            // Placeholders
            SetPlaceholder(txtName, "e.g John Smith");
            SetPlaceholder(txtAge, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition, "e.g Flu");
            SetPlaceholder(txtSearchbar2, "Search records...");

            // ---------------- Gender Dropdown Setup ----------------
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList; // user cannot type
            cmbGender.Items.Clear();                               // remove old items
            cmbGender.Items.AddRange(new string[]
            {
        "Male",
        "Female",
        "Other",
        "Prefer not to say"
            });
            cmbGender.SelectedIndex = -1; // no default selection

            // Optional: handle selection change
           cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
        }


        // --- Empty event handlers for Designer ---
        private void Age_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void Gender_Click(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint_1(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtAge_TextChanged(object sender, EventArgs e) { }
        private void txtContact_TextChanged(object sender, EventArgs e) { }
        private void txtCondition_TextChanged(object sender, EventArgs e) { }
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnPatients_Click(object sender, EventArgs e) { } // empty if not needed
        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            var doctors = new DoctorsControl();
            doctors.StartPosition = FormStartPosition.CenterScreen;
            doctors.ShowDialog();
            this.Show();
        }
        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            var appointments = new AppointmentsControl();
            appointments.StartPosition = FormStartPosition.CenterScreen;
            appointments.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT PatientId AS Id, FullName AS Name, Age, Gender, ContactNumber AS Contact, MedicalCondition AS Condition 
                                     FROM Patients";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
            }
            catch
            {
                dgvPatients.DataSource = sampleData;
            }

            FormatDataGridView();
        }

        private void SavePatient()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "e.g John Smith")
            {
                MessageBox.Show("Please enter patient name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 130)
            {
                MessageBox.Show("Please enter a valid age (1-130).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus(); return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGender.Focus(); return;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text) || txtContact.Text == "e.g +1234567890")
            {
                MessageBox.Show("Please enter contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus(); return;
            }

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO Patients (FullName, Age, Gender, ContactNumber, MedicalCondition)
                                     VALUES (@FullName, @Age, @Gender, @ContactNumber, @MedicalCondition)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                    cmd.Parameters.AddWithValue("@MedicalCondition", txtCondition.Text == "e.g Flu" ? "" : txtCondition.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Patient saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) => SavePatient();

        private void txtSearchbar2_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchbar2.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm) || searchTerm == "Search records...")
            {
                LoadPatients(); return;
            }

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT PatientId AS Id, FullName AS Name, Age, Gender, ContactNumber AS Contact, MedicalCondition AS Condition 
                                     FROM Patients
                                     WHERE FullName LIKE @Search OR ContactNumber LIKE @Search OR MedicalCondition LIKE @Search";
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{searchTerm}%");
                    adapter.Fill(dt);
                    dgvPatients.DataSource = dt;
                }

                FormatDataGridView();
            }
            catch { }
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            if (txt == null) return;
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.GotFocus += (s, e) => { if (txt.Text == placeholder) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Gray; } };
        }

        private void ClearForm()
        {
            txtName.Text = "e.g John Smith"; txtName.ForeColor = Color.Gray;
            txtAge.Text = "00"; txtAge.ForeColor = Color.Gray;
            txtContact.Text = "e.g +1234567890"; txtContact.ForeColor = Color.Gray;
            txtCondition.Text = "e.g Flu"; txtCondition.ForeColor = Color.Gray;
            cmbGender.SelectedIndex = -1;
        }

        private void FormatDataGridView()
        {
            if (dgvPatients.Columns.Count == 0) return;

            dgvPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            if (dgvPatients.Columns.Contains("Id")) dgvPatients.Columns["Id"].HeaderText = "ID";
            if (dgvPatients.Columns.Contains("Name")) dgvPatients.Columns["Name"].HeaderText = "Patient Name";
            if (dgvPatients.Columns.Contains("Age")) dgvPatients.Columns["Age"].HeaderText = "Age";
            if (dgvPatients.Columns.Contains("Gender")) dgvPatients.Columns["Gender"].HeaderText = "Gender";
            if (dgvPatients.Columns.Contains("Contact")) dgvPatients.Columns["Contact"].HeaderText = "Contact Number";
            if (dgvPatients.Columns.Contains("Condition")) dgvPatients.Columns["Condition"].HeaderText = "Medical Condition";
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Condition { get; set; }
    }
}
