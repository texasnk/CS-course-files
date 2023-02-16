using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class FormAsyncTest : Form
    {
        public static ListBox listRes1;
        public FormAsyncTest()
        {
            InitializeComponent();
            listRes1 = listRes;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            listRes.Items.Add("Button event started!");
            Example example = new Example();
            example.TaskLong();
            listRes.Items.Add("Button event finished!");
        }

        private async void btnRunAsync_Click(object sender, EventArgs e)
        {
            listRes.Items.Add("Button event started!");
            AsyncExample asyncExample = new AsyncExample();
            await asyncExample.TaskLong();
            listRes.Items.Add("Button event finished!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listRes.Items.Clear();
        }
    }
}
