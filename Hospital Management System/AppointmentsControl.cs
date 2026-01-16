using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AppointmentsControl : Form
    {
        // BindingList so DataGridView updates automatically
        private BindingList<Appointment> appointments = new BindingList<Appointment>();

        public AppointmentsControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;


            // Placeholder setup
            SetPlaceholder(txtName, "e.g John Smith");
            SetPlaceholder(txtName1, "e.g DR. John Smith");
            SetPlaceholder(txtDate, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition, "e.g Flu");
            SetPlaceholder(txtSearchbar2, "Search records...");
           
        }
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

        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsControl doctorsForm = new DoctorsControl();
            doctorsForm.StartPosition = FormStartPosition.CenterScreen;
            doctorsForm.Size = new Size(1536, 864);
            doctorsForm.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Form1 patientsForm = new Form1();
            patientsForm.StartPosition = FormStartPosition.CenterScreen;
            patientsForm.Size = new Size(1536, 864);
            patientsForm.Show();

            this.Hide();
        }





        private void label3_Click(object sender, EventArgs e)
        {
            string patientName = txtName.Text.Trim();
            string doctorName = txtName1.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string contact = txtContact.Text.Trim();
            string condition = txtCondition.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();

            // ---------- Validation ----------
            if (string.IsNullOrWhiteSpace(patientName) || patientName == "e.g John Smith" ||
                string.IsNullOrWhiteSpace(doctorName) || doctorName == "e.g DR. John Smith" ||
                string.IsNullOrWhiteSpace(ageText) || ageText == "00" ||
                string.IsNullOrWhiteSpace(contact) || contact == "e.g +1234567890" ||
                string.IsNullOrWhiteSpace(condition) || condition == "e.g Flu" ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AppointmentsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
