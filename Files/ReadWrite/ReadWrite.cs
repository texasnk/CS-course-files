using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadWriteTXT
{
    public partial class FormReadWrite : Form
    {
        string path = Directory.GetCurrentDirectory();
        public FormReadWrite()
        {
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                path = path.Remove(path.LastIndexOf("\\"));
            }
        }

        private void btnWriteTXT_Click(object sender, EventArgs e)
        {

            StreamWriter writer = new StreamWriter(path + @"\files\file.txt", true, Encoding.UTF8);

            writer.WriteLine(txtContent.Text);
            
            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        private void btnReadTXT_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path + @"\files\file.txt", Encoding.Default);

            string txt = reader.ReadToEnd();
            txtContent.Text = txt;
            reader.Close();

        }
    }
}
