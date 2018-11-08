using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingHangul
{
    public partial class Train : Form
    {

        string fileLocationStr;
        OpenFileDialog Picture;

        public Train()
        {
            InitializeComponent();

            // setting the value of the file you can select
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //make so that picture can be strectch
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void loadIn_Click(object sender, EventArgs e)
        {
  
        }

        private void trainging_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //make the pop up that selected the file
            DialogResult result = openFileDialog1.ShowDialog();

            //see if the result is ok       duh
            if(result == DialogResult.OK)
            {   
                //show the user the directory
                fileLocation.Text= openFileDialog1.FileName;

                if (!openFileDialog1.CheckFileExists)
                {
                    MessageBox.Show("The file do not exist", "Error");
                }
       
                //saving the picture file in here
                Picture = openFileDialog1;

                
                //make so that user can see which picture is selected in pictureBox
                pictureBox1.ImageLocation = Picture.FileName;
            }


        }
    }
}
