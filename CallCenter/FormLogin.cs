using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "030216" && this.textBox2.Text == "303622")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("UserName or Passaord is wrong!","Alert!");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "030216";
            this.textBox2.Text = "303622";
        }
    }
}
