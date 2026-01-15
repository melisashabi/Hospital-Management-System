namespace Hospital_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Hospital_Management_System.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchbar2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGender
            // 
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Location = new System.Drawing.Point(376, 235);
            this.cmbGender.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbGender.MinimumSize = new System.Drawing.Size(250, 0);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 36);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtAge.Location = new System.Drawing.Point(31, 235);
            this.txtAge.MaximumSize = new System.Drawing.Size(300, 100);
            this.txtAge.MaxLength = 2;
            this.txtAge.MinimumSize = new System.Drawing.Size(250, 35);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(300, 35);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.button1.Location = new System.Drawing.Point(31, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(649, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(26, 100);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(80, 20);
            this.FullName.TabIndex = 0;
            this.FullName.Text = "Full Name";
            this.FullName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(31, 195);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(38, 20);
            this.Age.TabIndex = 9;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.Age_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(31, 436);
            this.txtCondition.MaximumSize = new System.Drawing.Size(645, 250);
            this.txtCondition.MinimumSize = new System.Drawing.Size(645, 150);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(645, 150);
            this.txtCondition.TabIndex = 6;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtContact.Location = new System.Drawing.Point(31, 330);
            this.txtContact.MaximumSize = new System.Drawing.Size(647, 50);
            this.txtContact.MinimumSize = new System.Drawing.Size(410, 40);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(645, 40);
            this.txtContact.TabIndex = 5;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(371, 195);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 20);
            this.Gender.TabIndex = 10;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contact Number";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtCondition);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(398, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 747);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtName.Location = new System.Drawing.Point(31, 142);
            this.txtName.MaximumSize = new System.Drawing.Size(0, 40);
            this.txtName.MinimumSize = new System.Drawing.Size(0, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(645, 40);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Specialization";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Patient Registration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.DataSource = this.dataSet1BindingSource;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvPatients.Location = new System.Drawing.Point(330, 924);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 40;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(858, 444);
            this.dgvPatients.TabIndex = 14;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "MediCare";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label6.Location = new System.Drawing.Point(196, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Plus";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.btnAppointments);
            this.panel2.Controls.Add(this.btnDoctors);
            this.panel2.Controls.Add(this.btnPatients);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 1368);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Location = new System.Drawing.Point(26, 250);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(231, 55);
            this.btnAppointments.TabIndex = 4;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Location = new System.Drawing.Point(26, 162);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(231, 55);
            this.btnDoctors.TabIndex = 3;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.BtnDoctors_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(26, 73);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(231, 55);
            this.btnPatients.TabIndex = 2;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearchbar2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1217, 97);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtSearchbar2
            // 
            this.txtSearchbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtSearchbar2.Location = new System.Drawing.Point(931, 29);
            this.txtSearchbar2.Name = "txtSearchbar2";
            this.txtSearchbar2.Size = new System.Drawing.Size(174, 26);
            this.txtSearchbar2.TabIndex = 1;
            this.txtSearchbar2.TextChanged += new System.EventHandler(this.txtSearchbar2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patients Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(31, 672);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(649, 59);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1224, 1055);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(2000, 2500);
            this.MinimumSize = new System.Drawing.Size(0, 998);
            this.Name = "Form1";
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchbar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
    }
}

