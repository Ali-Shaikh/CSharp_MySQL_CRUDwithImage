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
using System.IO;
using System.Data.SqlClient;

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
                    MySqlDataAdapter _adapter = new MySqlDataAdapter("SELECT `ID`, `First Name`, `Last Name`, `Email`, `Mobile`, `Course`, `Gender` FROM student_img", conn);
                    //MySqlDataAdapter _adapter = new MySqlDataAdapter("SELECT `ID`, `First Name`, `Last Name`, `Email`, `Mobile`, `Course`, `Gender` , `Image` FROM student_img", conn);

                    DataSet _dataset = new DataSet();
                    _adapter.Fill(_dataset, "table");
                    dataGridViewStudent.DataSource = _dataset;
                    dataGridViewStudent.DataMember = "table";
                    lblRecords.Text = dataGridViewStudent.Rows.Count.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message, "Error Message",
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
            location = null;
            picLogo.Image = null;
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
                    if (cmd.ExecuteNonQuery() != 0)
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
            //insertData();
            InsertwithImage();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //updateData();
            updateDatawithImage();
        }

        private void dataGridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            reset();
            txtBoxID.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtBoxFName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["fname"].Value.ToString();
            txtBoxLName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["lname"].Value.ToString();
            txtBoxEmail.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtBoxMobile.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
            txtBoxCourse.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["course"].Value.ToString();
            comboBoxGender.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            if (getImage(txtBoxID.Text))
            {
                getImage(txtBoxID.Text);
                //location = textBox1.Text;

            }

            //getImage(txtBoxID.Text);
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

        //The String used to store the location of the file that is currently loaded in the picture box picFile
        String location;

        //The String used to store the name of the file that is currently loaded in the picture box picFile
        String fileName;
        private void picLogo_MouseDoubleClick(object sender, MouseEventArgs e)

        {

            openImageDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            //Showing the fileopen dialog box
            openImageDialog.ShowDialog();
            //showing the image opened in the picturebox
            //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.Image = new Bitmap(openImageDialog.FileName);
            //storing the location of the pic in variable
            location = openImageDialog.FileName;
            textBox1.Text = location;
            //storing the filename of the pic in variable
            fileName = openImageDialog.SafeFileName;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            //frm.Show();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        //public string ImageLocation
        //{
        //    get { return textBox1.Text; }
        //    set { textBox1.Text = value; }
        //}

        //public string FileName
        //{
        //    get { return textBox1.Text; }
        //    set { textBox1.Text = value; }
        //}

        private void updateDatawithImage()
        {

            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    if (location != null)
                    {
                        string loadImage = location;
                        byte[] ImageData = imageToByteArray(loadImage);

                        string CmdString = "Update `student_img` Set `First Name` = @FirstName, `Last Name`= @LastName, `Email`= @Email, `Mobile`= @Mobile, `Course`= @Course,  `Gender`= @Gender, `Image`= @Image WHERE ID =  @ID";

                        MySqlCommand cmd = new MySqlCommand(CmdString, conn);
                        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Mobile", MySqlDbType.VarChar, 11);
                        cmd.Parameters.Add("@Course", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Gender", MySqlDbType.Enum);
                        cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32, 4);

                        cmd.Parameters["@FirstName"].Value = txtBoxFName.Text;
                        cmd.Parameters["@LastName"].Value = txtBoxLName.Text;
                        cmd.Parameters["@Email"].Value = txtBoxEmail.Text;
                        cmd.Parameters["@Mobile"].Value = txtBoxMobile.Text;
                        cmd.Parameters["@Course"].Value = txtBoxCourse.Text;
                        cmd.Parameters["@Gender"].Value = comboBoxGender.Text;
                        cmd.Parameters["@Image"].Value = ImageData;
                        cmd.Parameters["@ID"].Value = int.Parse(txtBoxID.Text.Trim());

                        conn.Open();

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

                    else
                    {
                        string CmdString = "Update `student_img` Set `First Name` = @FirstName, `Last Name`= @LastName, `Email`= @Email, `Mobile`= @Mobile, `Course`= @Course, `Gender`= @Gender WHERE ID =  @ID";

                        MySqlCommand cmd = new MySqlCommand(CmdString, conn);
                        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Mobile", MySqlDbType.VarChar, 11);
                        cmd.Parameters.Add("@Course", MySqlDbType.VarChar, 255);
                        cmd.Parameters.Add("@Gender", MySqlDbType.Enum);
                        cmd.Parameters.Add("@Image", MySqlDbType.Blob);
                        cmd.Parameters.Add("@ID", MySqlDbType.Int32, 4);

                        cmd.Parameters["@FirstName"].Value = txtBoxFName.Text;
                        cmd.Parameters["@LastName"].Value = txtBoxLName.Text;
                        cmd.Parameters["@Email"].Value = txtBoxEmail.Text;
                        cmd.Parameters["@Mobile"].Value = txtBoxMobile.Text;
                        cmd.Parameters["@Course"].Value = txtBoxCourse.Text;
                        cmd.Parameters["@Gender"].Value = comboBoxGender.Text;
                        cmd.Parameters["@ID"].Value = int.Parse(txtBoxID.Text.Trim());

                        conn.Open();

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertwithImage()
        {



            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {

                try
                {

                    string loadImage = location;
                    byte[] ImageData = imageToByteArray(loadImage);

                    string CmdString = "INSERT INTO `student_img` (`First Name`, `Last Name`, `Email`, `Mobile`, `Course`, `Gender`, `Image`) VALUES (@FirstName, @LastName, @Email, @Mobile, @Course, @Gender, @Image)";

                    MySqlCommand cmd = new MySqlCommand(CmdString, conn);
                    cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@Email", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@Mobile", MySqlDbType.VarChar, 11);
                    cmd.Parameters.Add("@Course", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@Gender", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Image", MySqlDbType.Blob);

                    cmd.Parameters["@FirstName"].Value = txtBoxFName.Text;
                    cmd.Parameters["@LastName"].Value = txtBoxLName.Text;
                    cmd.Parameters["@Email"].Value = txtBoxEmail.Text;
                    cmd.Parameters["@Mobile"].Value = txtBoxMobile.Text;
                    cmd.Parameters["@Course"].Value = txtBoxCourse.Text;
                    cmd.Parameters["@Gender"].Value = comboBoxGender.Text;
                    cmd.Parameters["@Image"].Value = ImageData;

                    conn.Open();

                    //MySqlCommand cmd = new MySqlCommand(cmd, conn);
                    if (cmd.ExecuteNonQuery() != 0)
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

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private byte[] imageToByteArray(string ImageFile)
        {

            FileStream stream = new FileStream(ImageFile, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            // Convert image to byte array.
            byte[] photo = reader.ReadBytes((int)stream.Length);

            return photo;

        }

        private void getImage_other()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Image FROM student_img WHERE ID =  @ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    //int id = 10;
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtBoxID.Text.Trim()));

                    var da = new MySqlDataAdapter(cmd);
                    var ds = new DataSet();
                    da.Fill(ds, "Image");
                    int count = ds.Tables["Image"].Rows.Count;

                    if (count > 0)
                    {
                        var data = (Byte[])(ds.Tables["Image"].Rows[count - 1]["Image"]);
                        var stream = new MemoryStream(data);
                        picLogo.Image = Image.FromStream(stream);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error!\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private Boolean getImage(String ID)
        {
            Boolean result = false;
            using (MySqlConnection conn = new MySqlConnection(connectionManager.connectionString))
            {
                try
                {
                    var id = int.Parse(ID);
                    conn.Open();

                    string query = "SELECT Image FROM student_img WHERE ID =  @ID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ID", id);

                    var da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //textBoxID.Text = dt.Rows[0][0].ToString();
                    //textBoxNAME.Text = dt.Rows[0][1].ToString();
                    //textBoxDescription.Text = dt.Rows[0][2].ToString();
                    //set image from mysql database to pictureBox
                    int count = dt.Rows.Count;
                    if (count > 0)
                    {
                        byte[] img = (byte[])dt.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);

                        if (ms.Length == 0)
                        {
                            picLogo.ImageLocation = "https://placeholdit.imgix.net/~text?txtsize=40&bg=262835&txtclr=ffffff&txt=Image+Not+Available&w=200&h=218";
                        }

                        else {

                            picLogo.Image = Image.FromStream(ms);
                            da.Dispose();
                            result = true;
                            }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in getImage\n" + ex.Message, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            return result;
        }


    }
}
