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
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // You can leave this empty or add logic if needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // *** Connection Test Logic - Runs when the form loads ***
            // Retrieve the connection string by its name "DefaultConnection" from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connection to SQL Server successful!");
                }
            }
            catch (SqlException ex)
            {
                // This will display the exact error message if it fails
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // *** Patient Saving Logic - Runs when button1 is clicked ***
            try
            {
                // Retrieve the connection string by its name "DefaultConnection" from App.config
                string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    // 2. The SQL Command
                    // NOTE: This assumes you have TextBoxes/ComboBoxes named: txtName, txtAge, cmbGender, txtContact, txtCondition
                    string query = "INSERT INTO Patients (Name, Age, Gender, Contact, Condition) VALUES (@Name, @Age, @Gender, @Contact, @Condition)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    // 3. Mapping your inputs to the database columns
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

        private void button2_Click(object sender, EventArgs e)
        {
            // This button's event is currently empty in this merged code. 
            // You can add different logic here (e.g., viewing records) later.
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
