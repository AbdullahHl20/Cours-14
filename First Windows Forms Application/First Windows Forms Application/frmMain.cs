using MyFirstWinFormsProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Windows_Forms_Application
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPartOne_Click(object sender, EventArgs e)
        {
            Form frmOne = new Form1();
            frmOne.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmOne = new Form1();
            frmOne.ShowDialog();
        }

        private void btnMesageBoxForm_Click(object sender, EventArgs e)
        {
            Form frmMessage = new frmMessageBox();
            frmMessage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmMessage = new frmChkRadioGroup();
            frmMessage.ShowDialog();
        }

        private void button3_Click(object sender , EventArgs e)
        {
            Form frmTextBox = new frmTextBox();
            frmTextBox.ShowDialog();
        }

        private void button4_Click(object sender , EventArgs e)
        {
            Form frmPictureBox = new frmPictureBox();
            frmPictureBox.ShowDialog();
        }
    }
}
