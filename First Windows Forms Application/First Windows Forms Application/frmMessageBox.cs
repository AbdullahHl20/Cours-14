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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi This Is a Message!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi This Is a Message!", "This Is A Title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "Confirm!", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {
                MessageBox.Show("User Pressed Ok");
            }
        }
    }
}
