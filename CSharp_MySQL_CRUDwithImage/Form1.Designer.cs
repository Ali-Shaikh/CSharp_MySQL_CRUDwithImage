namespace CSharp_MySQL_CRUDwithImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblDBStatus = new System.Windows.Forms.Label();
            this.lblDBStatusValue = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnForm2);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxID);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblRecords);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxMobile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.txtBoxLName);
            this.groupBox1.Controls.Add(this.txtBoxFName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Database";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(504, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 218);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picLogo_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Student ID:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Location = new System.Drawing.Point(98, 30);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(54, 20);
            this.txtBoxID.TabIndex = 14;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(422, 213);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(341, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(260, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(460, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 13);
            this.lblRecords.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Select Gender",
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(98, 160);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(399, 21);
            this.comboBoxGender.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Students:";
            // 
            // txtBoxCourse
            // 
            this.txtBoxCourse.Location = new System.Drawing.Point(98, 187);
            this.txtBoxCourse.Name = "txtBoxCourse";
            this.txtBoxCourse.Size = new System.Drawing.Size(399, 20);
            this.txtBoxCourse.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender:";
            // 
            // txtBoxMobile
            // 
            this.txtBoxMobile.Location = new System.Drawing.Point(98, 108);
            this.txtBoxMobile.Name = "txtBoxMobile";
            this.txtBoxMobile.Size = new System.Drawing.Size(399, 20);
            this.txtBoxMobile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mobile No:";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(98, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(179, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(98, 134);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(399, 20);
            this.txtBoxEmail.TabIndex = 6;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(98, 82);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(399, 20);
            this.txtBoxLName.TabIndex = 4;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(98, 56);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(399, 20);
            this.txtBoxFName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // lblDBStatus
            // 
            this.lblDBStatus.AutoSize = true;
            this.lblDBStatus.Location = new System.Drawing.Point(19, 9);
            this.lblDBStatus.Name = "lblDBStatus";
            this.lblDBStatus.Size = new System.Drawing.Size(89, 13);
            this.lblDBStatus.TabIndex = 4;
            this.lblDBStatus.Text = "Database Status:";
            // 
            // lblDBStatusValue
            // 
            this.lblDBStatusValue.AutoSize = true;
            this.lblDBStatusValue.Location = new System.Drawing.Point(109, 9);
            this.lblDBStatusValue.Name = "lblDBStatusValue";
            this.lblDBStatusValue.Size = new System.Drawing.Size(0, 13);
            this.lblDBStatusValue.TabIndex = 5;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewStudent.ColumnHeadersHeight = 21;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.gender,
            this.email,
            this.mobile,
            this.course});
            this.dataGridViewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewStudent.Location = new System.Drawing.Point(12, 292);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidth = 50;
            this.dataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudent.Size = new System.Drawing.Size(710, 353);
            this.dataGridViewStudent.TabIndex = 6;
            this.dataGridViewStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "Student ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 83;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "First Name";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 82;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "Last Name";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 83;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 67;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email Address";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 98;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "Mobile";
            this.mobile.HeaderText = "Mobile Number";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 103;
            // 
            // course
            // 
            this.course.DataPropertyName = "Course";
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            this.course.ReadOnly = true;
            this.course.Width = 65;
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(16, 213);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 657);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.lblDBStatusValue);
            this.Controls.Add(this.lblDBStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MySQL - Student Database ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCourse;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblDBStatus;
        private System.Windows.Forms.Label lblDBStatusValue;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

