using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    // A complete, single-file implementation of the Hospital Management UI
    // To run this: Create a new Windows Forms App (.NET Framework) and replace Program.cs content with this.

    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        // === DATABASE CONNECTION STRING ===
        // UPDATE THIS to match your SQL Server instance
        private string connectionString = @"Data Source=DESKTOP-1E62B0U\SQLEXPRESS,56385;Integrated Security=True;Trust Server Certificate=True";
        // UI Controls
        private TabControl tabControl;
        private TabPage tabPatients;
        private TabPage tabDoctors;

        // Patient Tab Controls
        private DataGridView dgvPatients;
        private TextBox txtName, txtAge, txtContact, txtCondition;
        private ComboBox cmbGender;
        private Button btnAdd, btnUpdate, btnDelete, btnLoad;

        public MainForm()
        {
            this.Text = "Hospital Management System";
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Main Tab Control
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // 1. Setup Patients Tab
            tabPatients = new TabPage("Patients Management");
            tabPatients.BackColor = Color.White;
            SetupPatientTab();
            tabControl.TabPages.Add(tabPatients);

            // 2. Setup Doctors Tab (Placeholder)
            tabDoctors = new TabPage("Doctors");
            Label lblUnderConstruction = new Label
            {
                Text = "Doctors Module Coming Soon",
                AutoSize = true,
                Location = new Point(50, 50),
                Font = new Font("Arial", 16)
            };
            tabDoctors.Controls.Add(lblUnderConstruction);
            tabControl.TabPages.Add(tabDoctors);

            this.Controls.Add(tabControl);
        }

        private void SetupPatientTab()
        {
            // GroupBox for Inputs
            GroupBox grpInput = new GroupBox();
            grpInput.Text = "Patient Registration";
            grpInput.Location = new Point(20, 20);
            grpInput.Size = new Size(300, 550);

            // Labels and Inputs helper
            int y = 30;
            int spacing = 50;

            CreateLabel(grpInput, "Full Name:", 20, y);
            txtName = CreateTextBox(grpInput, 20, y + 20);
            y += spacing;

            CreateLabel(grpInput, "Age:", 20, y);
            txtAge = CreateTextBox(grpInput, 20, y + 20);
            y += spacing;

            CreateLabel(grpInput, "Gender:", 20, y);
            cmbGender = new ComboBox { Location = new Point(20, y + 20), Width = 250, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.SelectedIndex = 0;
            grpInput.Controls.Add(cmbGender);
            y += spacing;

            CreateLabel(grpInput, "Contact No:", 20, y);
            txtContact = CreateTextBox(grpInput, 20, y + 20);
            y += spacing;

            CreateLabel(grpInput, "Medical Condition:", 20, y);
            txtCondition = CreateTextBox(grpInput, 20, y + 20);
            y += spacing + 20;

            // Buttons
            btnAdd = CreateButton(grpInput, "Save Record", 20, y, Color.SeaGreen);
            btnAdd.Click += BtnAdd_Click;
            y += 45;

            btnUpdate = CreateButton(grpInput, "Update Selected", 20, y, Color.SteelBlue);
            btnUpdate.Click += BtnUpdate_Click;
            y += 45;

            btnDelete = CreateButton(grpInput, "Delete Selected", 20, y, Color.IndianRed);
            btnDelete.Click += BtnDelete_Click;

            // DataGridView for Display
            dgvPatients = new DataGridView();
            dgvPatients.Location = new Point(340, 28);
            dgvPatients.Size = new Size(620, 540);
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.ReadOnly = true;
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.CellClick += DgvPatients_CellClick;

            tabPatients.Controls.Add(grpInput);
            tabPatients.Controls.Add(dgvPatients);

            // Initial Load
            // LoadData(); // Uncomment when DB is connected
        }

        // --- Event Handlers ---

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string query = "INSERT INTO Patients (Name, Age, Gender, Contact, Condition) VALUES (@Name, @Age, @Gender, @Contact, @Condition)";
                ExecuteQuery(query, "Added");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && dgvPatients.SelectedRows.Count > 0)
            {
                string id = dgvPatients.SelectedRows[0].Cells["PatientID"].Value.ToString();
                string query = $"UPDATE Patients SET Name=@Name, Age=@Age, Gender=@Gender, Contact=@Contact, Condition=@Condition WHERE PatientID={id}";
                ExecuteQuery(query, "Updated");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                string id = dgvPatients.SelectedRows[0].Cells["PatientID"].Value.ToString();
                string query = $"DELETE FROM Patients WHERE PatientID={id}";
                ExecuteQuery(query, "Deleted");
                ClearInputs();
            }
        }

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtCondition.Text = row.Cells["Condition"].Value.ToString();
            }
        }

        // --- Helpers & Database Logic ---

        private void ExecuteQuery(string query, string actionType)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters if it's an Insert or Update
                        if (actionType != "Deleted")
                        {
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                            cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                            cmd.Parameters.AddWithValue("@Condition", txtCondition.Text);
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Patient {actionType} Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message + "\nEnsure your connection string is correct and SQL Server is running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
            }
            catch { /* Silent fail for UI demo purposes if DB not connected */ }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Name and Age are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtAge.Clear();
            txtContact.Clear();
            txtCondition.Clear();
            cmbGender.SelectedIndex = 0;
        }

        // --- UI Component Builders ---
        private void CreateLabel(Control parent, string text, int x, int y)
        {
            Label lbl = new Label { Text = text, Location = new Point(x, y), AutoSize = true };
            parent.Controls.Add(lbl);
        }

        private TextBox CreateTextBox(Control parent, int x, int y)
        {
            TextBox txt = new TextBox { Location = new Point(x, y), Width = 250 };
            parent.Controls.Add(txt);
            return txt;
        }

        private Button CreateButton(Control parent, string text, int x, int y, Color color)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Width = 250,
                Height = 35,
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            parent.Controls.Add(btn);
            return btn;
        }
    }
}   