using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class DoctorsControl : Form
    {
        // List to hold doctors in memory
        private BindingList<Doctor> doctors = new BindingList<Doctor>();


        public DoctorsControl()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;

            // Placeholder setup
            SetPlaceholder(txtName, "e.g Dr. John Smith");
            SetPlaceholder(txtAge, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition1, "e.g Pediatrician");
            SetPlaceholder(txtSearchbar3, "Search records...");

            // Gender dropdown setup
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Items.Clear();
            comboBoxGender.Items.AddRange(new string[] { "Male", "Female", "Other", "Prefer not to say" });
            comboBoxGender.SelectedIndex = -1;

            // Bind DataGridView to doctors list
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = doctors;
        }

        // Placeholder helper
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

        // ---------------- Button Clicks ----------------

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Form1 patientsForm = new Form1();
            patientsForm.StartPosition = FormStartPosition.CenterScreen;
            patientsForm.Size = new Size(1536, 864);
            patientsForm.Show();
            this.Hide();
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsControl appointmentsForm = new AppointmentsControl();
            appointmentsForm.StartPosition = FormStartPosition.CenterScreen;
            appointmentsForm.Size = new Size(1536, 864);
            appointmentsForm.Show();
            this.Hide();
        }

        // ---------------- Register Doctor ----------------
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string doctorName = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string contact = txtContact.Text.Trim();
            string specialty = txtCondition1.Text.Trim();
            string gender = comboBoxGender.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(doctorName) || doctorName == "e.g Dr. John Smith" ||
                string.IsNullOrWhiteSpace(ageText) || ageText == "00" ||
                string.IsNullOrWhiteSpace(contact) || contact == "e.g +1234567890" ||
                string.IsNullOrWhiteSpace(specialty) || specialty == "e.g Pediatrician" ||
                string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a number.");
                return;
            }

            var newDoctor = new Doctor
            {
                Id = doctors.Count > 0 ? doctors.Max(d => d.Id) + 1 : 1,
                Name = doctorName,
                Age = age,
                Contact = contact,
                Specialty = specialty,
                Gender = gender
            };

            doctors.Add(newDoctor);

            MessageBox.Show("Doctor registered successfully!");

            // Reset fields
            txtName.Text = "e.g Dr. John Smith"; txtName.ForeColor = Color.Gray;
            txtAge.Text = "00"; txtAge.ForeColor = Color.Gray;
            txtContact.Text = "e.g +1234567890"; txtContact.ForeColor = Color.Gray;
            txtCondition1.Text = "e.g Pediatrician"; txtCondition1.ForeColor = Color.Gray;
            comboBoxGender.SelectedIndex = -1;

            MessageBox.Show("Doctor registered successfully!");
        }

        // ---------------- Empty handlers to satisfy Designer ----------------
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void DoctorsControl_Load(object sender, EventArgs e)
        {
            // Gender dropdown
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Items.Clear();
            comboBoxGender.Items.AddRange(new string[]
            {
        "Male",
        "Female",
        "Other",
        "Prefer not to say"
            });
        }

    }

    // ---------------- Helper Class ----------------
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public string Specialty { get; set; }
        public string Gender { get; set; }
    }
}
