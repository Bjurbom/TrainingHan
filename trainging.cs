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
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void loadIn_Click(object sender, EventArgs e)
        {
            //Forms
        }

        private void trainging_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                fileLocationStr = openFileDialog1.FileName;
                if (!openFileDialog1.CheckFileExists)
                {
                    MessageBox.Show("The file do not exist", "Error");
                }
                fileLocation.Text = fileLocationStr;

                Picture = openFileDialog1;

                

                pictureBox1.ImageLocation = Picture.FileName;
            }


        }
    }
}
