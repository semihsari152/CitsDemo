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

namespace CitsDemo
{
    public partial class LearningsTable : Form
    {
        public LearningsTable()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           //StreamReader reader = new StreamReader(path);

            //tbxDatas.Text = reader.ReadToEnd();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string fname = openFileDialog.FileName;

            StreamReader  reader = new StreamReader(fname);
            tbxDatas.Text = reader.ReadToEnd();


        }
    }
}
