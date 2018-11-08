using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingHangul;

namespace TrainingHangul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadIn_Click(object sender, EventArgs e)
        {
            //make the other form
            TrainingHangul.Train TrainWindow = new TrainingHangul.Train();

            //shows the other window and closes this one
            TrainWindow.Show();
            this.Hide();
        }
    }
}
