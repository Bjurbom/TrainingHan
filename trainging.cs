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


        public Train()
        {
            InitializeComponent();
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
                fileLocation.Text = fileLocationStr;
            }
        }
    }
}
