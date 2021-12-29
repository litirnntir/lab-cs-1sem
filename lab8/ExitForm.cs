using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class ExitForm : System.Windows.Forms.Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ExitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
