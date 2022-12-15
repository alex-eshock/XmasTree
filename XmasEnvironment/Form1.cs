using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmasEnvironment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // setting the background of santa's crack as transparent
            pictureBox1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
