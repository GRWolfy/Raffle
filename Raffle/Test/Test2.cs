using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raffle.Test
{
    public partial class Test2 : Form
    {
        List<int> listIdNumber = new List<int>();

        public Test2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectWinner_Click(object sender, EventArgs e)
        {
            int count = 0;

            Connection.DB();
            Function.gen = "SELECT DISTINCT * FROM students";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            while (Function.reader.Read())
            {
                listIdNumber.Add(Convert.ToInt32(Function.reader["idnumber"]));
                count++;
            }

            txtCongratulations.Visible = true;
            txtWinner.Visible = true;
            txtWinner.Text = getName(listIdNumber.ElementAt(new Random().Next(0, count))).ToString();
        }

        private string getName(int idnumber)
        {
            Connection.DB();
            Function.gen = "SELECT * FROM students WHERE idnumber = '"+ idnumber +"' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            if (Function.reader.HasRows)
            {
                Function.reader.Read();
                return Function.reader["firstname"].ToString() + " " + Function.reader["lastname"].ToString();
            }

            return null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var back = new Test();
            back.Show();
            Hide();
        }
    }
}
