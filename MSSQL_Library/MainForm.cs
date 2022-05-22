using System;
using System.Data;
using System.Data.SqlClient;

namespace MSSQL_Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Common.SqlConnection.Close();
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook();

            book.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Common.SqlConnection.State != System.Data.ConnectionState.Closed)
                Common.SqlConnection.Close();
            Application.Exit();
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            if (tbSearchString.Text.Contains("\"") || tbSearchString.Text.Contains(";"))
            {
                MessageBox.Show("Sanitization of input failed");
                return;
            }

            tbSearchString.Text = tbSearchString.Text.ToUpper();

            string query = "SELECT * FROM BOOK WHERE TITLE ";
            if (radioExact.Checked)
                query += $"= '{tbSearchString.Text}'";
            else if (radioAnyBefore.Checked)
                query += $"LIKE '%{tbSearchString.Text}'";
            else if (radioAnyAfter.Checked)
                query += $"LIKE '{tbSearchString.Text}%'";
            else if (radioAnyBeforeAfter.Checked)
                query += $"LIKE '%{tbSearchString.Text}%'";

            //MessageBox.Show(query);

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Common.SqlConnection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvResults.DataSource = dt;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (tbSearchString.Text.Contains("\"") || tbSearchString.Text.Contains(";") || tbSearchString.Text.Contains("\'"))
            {
                MessageBox.Show("Sanitization of input failed");
                return;
            }

            tbSearchString.Text = tbSearchString.Text.ToUpper();

            string query = "SELECT * FROM BOOK WHERE AUTHOR ";
            if (radioExact.Checked)
                query += $"= '{tbSearchString.Text}'";
            else if (radioAnyBefore.Checked)
                query += $"LIKE '%{tbSearchString.Text}'";
            else if (radioAnyAfter.Checked)
                query += $"LIKE '{tbSearchString.Text}%'";
            else if (radioAnyBeforeAfter.Checked)
                query += $"LIKE '%{tbSearchString.Text}%'";

            //MessageBox.Show(query);

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Common.SqlConnection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvResults.DataSource = dt;
            }
        }

        private void btnSearchYear_Click(object sender, EventArgs e)
        {
            if (tbSearchString.Text.Contains("\"") || tbSearchString.Text.Contains(";"))
            {
                MessageBox.Show("Sanitization of input failed");
                return;
            }

            tbSearchString.Text = tbSearchString.Text.ToUpper();

            string query = "SELECT * FROM BOOK WHERE YEAR ";
            if (radioExact.Checked)
                query += $"= {tbSearchString.Text}";
            else if (radioAnyBefore.Checked)
                query += $"< {tbSearchString.Text}";
            else if (radioAnyAfter.Checked)
                query += $"> {tbSearchString.Text}";
            else if (radioAnyBeforeAfter.Checked)
                query += $"BETWEEN {tbSearchString.Text} AND {DateTime.Now.Year}";

            //MessageBox.Show(query);

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Common.SqlConnection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvResults.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUser add_user = new AddUser();
            add_user.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RentalViewer rentalViewer = new RentalViewer();
            rentalViewer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewRental newRental = new NewRental();
            newRental.ShowDialog();
        }
    }
}