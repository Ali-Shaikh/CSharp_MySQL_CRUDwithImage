using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CSharp_MySQL_CRUDwithImage.App_data;

namespace CSharp_MySQL_CRUDwithImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnectionStatus();
            //getTotalStudents();
            comboBoxGender.SelectedIndex = 0;

        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    MySqlDataAdapter _adapter = new MySqlDataAdapter("SELECT * FROM student", conn);
                    DataSet _dataset = new DataSet();
                    _adapter.Fill(_dataset, "table");
                    dataGridViewStudent.DataSource = _dataset;
                    dataGridViewStudent.DataMember = "table";
                    lblRecords.Text = dataGridViewStudent.Rows.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dbConnectionStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT VERSION()";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    string version = Convert.ToString(cmd.ExecuteScalar());
                    lblDBStatusValue.Text = "Connection Established! - " + "MySQL Version: " + version;

                }
                catch (Exception ex)
                {
                    lblDBStatusValue.Text = "Connection Error!\n" + ex.Message;
                }
            }

        }

        private void getTotalStudents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM student";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    string records = Convert.ToString(cmd.ExecuteScalar());
                    lblRecords.Text = records;

                }
                catch (Exception ex)
                {
                    lblRecords.Text = "Error!";
                }
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reset()
        {
            txtBoxID.Text = txtBoxFName.Text = txtBoxLName.Text = txtBoxEmail.Text = txtBoxMobile.Text
                = txtBoxCourse.Text = string.Empty;
            comboBoxGender.SelectedIndex = 0;
            txtBoxID.Enabled = btnDelete.Enabled = btnUpdate.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void insertData()
        {
            string sql = "INSERT INTO `student` (`First Name`, `Last Name`, `Email`, `Mobile`, `Course`, `Gender`) VALUES ('" + txtBoxFName.Text.Trim() + "','" + txtBoxLName.Text.Trim() + "','" + txtBoxEmail.Text.Trim() + "','" + txtBoxMobile.Text.Trim() + "','" + txtBoxCourse.Text.Trim() + "','" + comboBoxGender.Text + "')";
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if(cmd.ExecuteNonQuery()!=0)
                    {
                        MessageBox.Show("Record Added Successfuly.", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                        LoadData();
                        //getTotalStudents();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void updateData()
        {
            string sql = "UPDATE `student` SET `First Name`='" + txtBoxFName.Text.Trim() + "', `Last Name`='" + txtBoxLName.Text.Trim() + "', `Email`='" + txtBoxEmail.Text.Trim() + "', `Mobile`='" + txtBoxMobile.Text.Trim() + "', `Course`='" + txtBoxCourse.Text.Trim() + "', `Gender`= '" + comboBoxGender.Text + "' WHERE ID = " + int.Parse(txtBoxID.Text.Trim());
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Record Updated Successfuly.", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                        LoadData();
                        //getTotalStudents();
                        //txtBoxID.Enabled = btnDelete.Enabled = btnUpdate.Enabled = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteData()
        {
            string sql = "DELETE FROM `student` WHERE ID = " + int.Parse(txtBoxID.Text.Trim());
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Record Deleted Successfuly.", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                        LoadData();
                        //getTotalStudents();
                        //txtBoxID.Enabled = btnDelete.Enabled = btnUpdate.Enabled = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //private void dataGridViewStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtBoxID.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["id"].Value.ToString();
        //    txtBoxFName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["fname"].Value.ToString();
        //    txtBoxLName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["lname"].Value.ToString();
        //    txtBoxEmail.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["email"].Value.ToString();
        //    txtBoxMobile.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
        //    txtBoxCourse.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["course"].Value.ToString();
        //    comboBoxGender.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["gender"].Value.ToString();

        //    txtBoxID.Enabled = btnDelete.Enabled = btnUpdate.Enabled = true;
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxID.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBoxFName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["fname"].Value.ToString();
            txtBoxLName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["lname"].Value.ToString();
            txtBoxEmail.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtBoxMobile.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
            txtBoxCourse.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["course"].Value.ToString();
            comboBoxGender.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            txtBoxID.Enabled = btnDelete.Enabled = btnUpdate.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this record?\nOnce deleted this cannot be reversed.",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                deleteData();
            }
            else
            {
                // If 'No', do something here.
                reset();
                LoadData();
            }
            
        }
    }
}
