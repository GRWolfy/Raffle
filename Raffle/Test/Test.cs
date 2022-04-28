using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raffle.Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void viewStudentsDb()
        {
            Connection.DB();
            Function.gen = "SELECT * FROM students";
            Function.fill(Function.gen, datagridviewRaffle);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            viewStudentsDb();
        }

        /*private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select file";
            dlg.InitialDirectory = @"c:\";
            dlg.FileName = txtFileName.Text;
            dlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlg.FileName;
                Import();
                Application.DoEvents();
            }
        }*/
    }
}
