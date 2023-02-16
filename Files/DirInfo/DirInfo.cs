using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirInfo
{
    public partial class DirInfo : Form
    {
        public DirInfo()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory());

            List.Items.Clear();
            List.Items.Add(info.FullName);
            List.Items.Add(info.Parent);
            List.Items.Add(info.Name);
            List.Items.Add(info.CreationTime);
            List.Items.Add(info.Attributes);

            DirectoryInfo[] dirs = info.GetDirectories();
            foreach (var dir in dirs)
            {
                List.Items.Add(dir.FullName);
            }


            string linha = null;
            for (int i = 0; i < 100; i++)
            {
                linha += "-";
            }
            List.Items.Add(linha);
            



        }
    }
}
