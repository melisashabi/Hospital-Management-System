using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class DoctorsControl : Form
    {
        public DoctorsControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;


            // Placeholder setup
            SetPlaceholder(txtName, "e.g John Smith");
            SetPlaceholder(txtAge, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition1, "e.g Pediatrician");
            SetPlaceholder(txtSearchbar3, "Search records...");
           
           
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
      

        private void btnPatients_Click(object sender, EventArgs e)
        {
            
            Form1 patientsForm = new Form1();

            patientsForm.StartPosition = FormStartPosition.CenterScreen;
            patientsForm.Size = new System.Drawing.Size(1536, 864);
            patientsForm.Show();
           
            this.Hide();


        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {

            AppointmentsControl AppointmentsForm = new AppointmentsControl();
            AppointmentsForm.StartPosition = FormStartPosition.CenterScreen;
            AppointmentsForm.Size = new Size(1536 , 864);
            AppointmentsForm.Show();
            
            this.Hide();
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



        private void DoctorsControl_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




