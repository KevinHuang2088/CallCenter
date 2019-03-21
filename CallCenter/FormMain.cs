using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;

namespace CallCenter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void 用户权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string str1 = MyMD5.GetMD5("123");
            //CreateTxt(str1);
        }

        public void CreateTxt(string str)
        {
            FileStream fs = new FileStream(@"D:/CallCenterLog.txt", FileMode.Create);
            try
            {
                byte[] data = System.Text.Encoding.Default.GetBytes(str);
                fs.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Flush();
                fs.Close();
            }
        }
    }
}
