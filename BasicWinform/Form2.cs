using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1 ParentForm1
        {
            get;
            set;
        }

        public string TextBox1Text
        {
            get
            {
                return textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //form1.TextBox1Text = "Hello";
            //form1.Show();

            ParentForm1.TextBox1Text = "hello";
        }
    }
}
