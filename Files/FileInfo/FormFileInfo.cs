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
using System.Security.AccessControl;

namespace FileInfo
{
    public partial class FormFileInfo : Form
    {
        public FormFileInfo()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo info = new System.IO.FileInfo(Directory.GetCurrentDirectory());

            List.Items.Clear();
            List.Items.Add(info.Name);
            List.Items.Add(info.FullName);
            List.Items.Add(info.Directory);
            List.Items.Add(info.Extension);
            //List.Items.Add(info.DirectoryName);
            List.Items.Add(info.CreationTime);
                



        }
    }
}
