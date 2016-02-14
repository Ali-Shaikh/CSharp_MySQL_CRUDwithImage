using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharp_MySQL_CRUDwithImage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void btnBrowse_Click(object sender, EventArgs e)
        //{
        //    openPic.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
        //    //Showing the fileopen dialog box
        //    openPic.ShowDialog();
        //    //showing the image opened in the picturebox
        //    pictureBox1.BackgroundImage = new Bitmap(openPic.FileName);
        //    //storing the location of the pic in variable
        //    location = openPic.FileName;
        //    textBox2.Text = location;
        //    //storing the filename of the pic in variable
        //    fileName = openPic.SafeFileName;
        //}

        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.mainForm.LabelText = txtBoxImgPath.Text;
            this.Hide();
        }

        //The String used to store the location of the file that is currently loaded in the picture box picFile
        String location;

        //The String used to store the name of the file that is currently loaded in the picture box picFile
        String fileName;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            //Showing the fileopen dialog box
            openFileDialogImage.ShowDialog();
            //showing the image opened in the picturebox
            pictureBox1.BackgroundImage = new Bitmap(openFileDialogImage.FileName);
            //storing the location of the pic in variable
            location = openFileDialogImage.FileName;
            txtBoxImgPath.Text = location;
            //storing the filename of the pic in variable
            fileName = openFileDialogImage.SafeFileName;
        }
    }
}
