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

            // FIX: Check if dataGridView1 exists, create it if not
            if (dataGridView1 == null)
            {
                dataGridView1 = new DataGridView();
                dataGridView1.Name = "dataGridView1";
                dataGridView1.Location = new Point(300, 100);
                dataGridView1.Size = new Size(1100, 600);

                // Find a container panel or add to form
                if (panel3 != null)
                {
                    panel3.Controls.Add(dataGridView1);
                }
                else
                {
                    this.Controls.Add(dataGridView1);
                }
                dataGridView1.BringToFront();
            }

            // ---------- Placeholders ----------
            SetPlaceholder(txtName, "e.g John Smith");
            SetPlaceholder(txtName1, "e.g DR. John Smith");
            SetPlaceholder(txtDate, "00");
            SetPlaceholder(txtContact, "e.g +1234567890");
            SetPlaceholder(txtCondition, "e.g Flu");
            SetPlaceholder(txtSearchbar2, "Search records...");


            // ---------- Gender dropdown ----------
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Items.Clear();
            comboBoxGender.Items.AddRange(new string[] { "Male", "Female", "Other", "Prefer not to say" });
            comboBoxGender.SelectedIndex = -1; // start with nothing selected
        }
        private void AppointmentsControl_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = true;
            appointments = new BindingList<Appointment>
    {
        new Appointment { Id = 1, Patient = "Anna", Doctor = "Dr Smith", Date = DateTime.Today, Status = "Scheduled", Gender = "Female" },
        new Appointment { Id = 2, Patient = "Mark", Doctor = "Dr Lee", Date = DateTime.Today.AddDays(1), Status = "Completed", Gender = "Male" }
    };


            dataGridView1.DataSource = appointments;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                switch (column.Name)
                {
                    case "Id":
                        column.HeaderText = "ID";
                        break;
                    case "Patient":
                        column.HeaderText = "Patient Name";
                        break;
                    case "Doctor":
                        column.HeaderText = "Doctor";
                        break;
                    case "Date":
                        column.HeaderText = "Appointment Date";
                        column.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;
                    case "Status":
                        column.HeaderText = "Status";
                        break;
                    case "Gender":
                        column.HeaderText = "Gender";
                        break;
                }
            }
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            if (txt == null) return;

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string patientName = txtName.Text.Trim();
            string doctorName = txtName1.Text.Trim();
            string ageText = txtDate.Text.Trim();
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

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a number.");
                return;
            }

            // ---------- Add new appointment ----------
            var newAppointment = new Appointment
            {
                Id = appointments.Count > 0 ? appointments.Max(a => a.Id) + 1 : 1,
                Patient = patientName,
                Doctor = doctorName,
                Date = DateTime.Now,
                Status = "Scheduled",
                Gender = gender
            };

            appointments.Add(newAppointment);

            // Refresh DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = appointments;

            // ---------- Reset fields ----------
            txtName.Text = "e.g John Smith"; txtName.ForeColor = Color.Gray;
            txtName1.Text = "e.g DR. John Smith"; txtName1.ForeColor = Color.Gray;
            txtDate.Text = "00"; txtDate.ForeColor = Color.Gray;
            txtContact.Text = "e.g +1234567890"; txtContact.ForeColor = Color.Gray;
            txtCondition.Text = "e.g Flu"; txtCondition.ForeColor = Color.Gray;
            comboBoxGender.SelectedIndex = -1;

            MessageBox.Show("Appointment registered successfully!");
        }

        // Empty Event Handlers
        private void label3_Click(object sender, EventArgs e) { }
        private void txtCondition_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an appointment to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Delete this appointment?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            appointments.RemoveAt(dataGridView1.CurrentRow.Index);

            MessageBox.Show("Appointment deleted successfully.");
        }


    }

    // ---------- Appointment class ----------
    public class Appointment
    {
        public int Id { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }


    }

}

