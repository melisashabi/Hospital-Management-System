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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.dataSet1 = new Hospital_Management_System.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.textBox4);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1186, 77);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.txtAge.Text = "00";
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 10);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.FullName.Size = new System.Drawing.Size(100, 25);
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
            this.Age.Size = new System.Drawing.Size(48, 25);
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
            this.txtCondition.Text = "Brief description of symptoms or diagnosis... ";
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtContact.Location = new System.Drawing.Point(31, 330);
            this.txtContact.MaximumSize = new System.Drawing.Size(647, 50);
            this.txtContact.MinimumSize = new System.Drawing.Size(410, 35);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(645, 35);
            this.txtContact.TabIndex = 5;
            this.txtContact.Text = "+383 000 000 000";
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Patient Name";
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtName.Location = new System.Drawing.Point(31, 141);
            this.txtName.MaximumSize = new System.Drawing.Size(800, 250);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(649, 35);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "e.g John Smith";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(371, 195);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(77, 25);
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
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contact Number";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtCondition);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(398, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 731);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(114, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "New Patient Registration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(293, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 170, 100);
            this.label3.MaximumSize = new System.Drawing.Size(500, 120);
            this.label3.MinimumSize = new System.Drawing.Size(400, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patient Management";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox4.Location = new System.Drawing.Point(866, 15);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 15, 70, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 28);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Search records...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medical Condition";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
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
            this.dgvPatients.Location = new System.Drawing.Point(316, 907);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 40;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(858, 444);
            this.dgvPatients.TabIndex = 14;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "MediCare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.label6.Location = new System.Drawing.Point(196, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Plus";
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
            this.panel2.Size = new System.Drawing.Size(283, 1313);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
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
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1207, 1055);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(2000, 2500);
            this.MinimumSize = new System.Drawing.Size(0, 1018);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
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
    }
}

