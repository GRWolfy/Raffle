using ExcelDataReader;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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
            //viewStudentsDb();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select file";
            dlg.FileName = txtFileName.Text;
            dlg.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            dlg.FilterIndex = 1;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlg.FileName;
                excelFileReader(dlg.FileName.ToString());
            }
        }

        public void excelFileReader(string path)
        {
            int count = 0;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();

            datagridviewRaffle.Visible = false;

            foreach (DataTable table in tables)
            {
                datagridviewRaffle.DataSource = table;
            }

            viewStudents(datagridviewRaffle.Rows.Count);
        }

        public void viewStudents(int count)
        {
            for (int i = 1; i < count; i++)
            {
                datagridStudents.Rows.Add(datagridviewRaffle.Rows[i].Cells[0].Value.ToString(),
                    datagridviewRaffle.Rows[i].Cells[1].Value.ToString(),
                    datagridviewRaffle.Rows[i].Cells[2].Value.ToString(),
                    datagridviewRaffle.Rows[i].Cells[3].Value.ToString(),
                    datagridviewRaffle.Rows[i].Cells[4].Value.ToString(),
                    datagridviewRaffle.Rows[i].Cells[5].Value.ToString());
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            int count = datagridStudents.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                int idnumber = Convert.ToInt32(datagridStudents.Rows[i].Cells[0].Value);
                string firstname = datagridStudents.Rows[i].Cells[1].Value.ToString();
                string lastname = datagridStudents.Rows[i].Cells[2].Value.ToString();
                string course = datagridStudents.Rows[i].Cells[3].Value.ToString();
                string yearlevel = datagridStudents.Rows[i].Cells[4].Value.ToString();
                string campus = datagridStudents.Rows[i].Cells[5].Value.ToString();

                if (!isAlreadyExist(idnumber))
                {
                    Connection.DB();
                    Function.gen = "INSERT INTO students(idnumber, firstname, lastname, course, yearlevel, campus) VALUES('" + idnumber + "', '" + firstname + "', '" + lastname + "', '" + course + "', '" + yearlevel + "', '" + campus + "')";
                    Function.command = new SqlCommand(Function.gen, Connection.con);
                    Function.command.ExecuteNonQuery();
                    Connection.con.Close();
                }
            }

            MessageBox.Show("Students information saved to database.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Boolean isAlreadyExist(int idnumber)
        {
            Connection.DB();
            Function.gen = "SELECT * FROM students WHERE username = '" + idnumber + "' ";
            Function.command = new SqlCommand(Function.gen, Connection.con);
            Function.reader = Function.command.ExecuteReader();

            return Function.reader.HasRows ? true : false;
        }

        private void btnGoToRaffle_Click(object sender, EventArgs e)
        {
            var raffle = new Test2();
            raffle.Show();
            Hide();
        }
    }
}
