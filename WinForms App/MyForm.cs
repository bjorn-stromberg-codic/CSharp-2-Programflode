using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_App
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();

            MyButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MyButton.Text = "You clicked me!";
        }
    }
}
