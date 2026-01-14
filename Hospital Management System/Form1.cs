using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None; 


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
            
            DoctorsControl doctorsForm = new DoctorsControl();
            doctorsForm.StartPosition = FormStartPosition.CenterScreen; 
            doctorsForm.Size = new Size(600, 400);                      
            doctorsForm.Show();                                         
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {

            AppointmentsControl AppointmentsForm = new AppointmentsControl();
            AppointmentsForm.StartPosition = FormStartPosition.CenterScreen;
            AppointmentsForm.Size = new Size(600, 400);
            AppointmentsForm.Show();
        }



        // ---------- Patient saving ----------
        private void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to SQL Server successful!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
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

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchbar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
