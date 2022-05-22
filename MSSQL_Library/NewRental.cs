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

namespace MSSQL_Library
{
    public partial class NewRental : Form
    {
        public NewRental()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = Common.Sanitize(txtTitle.Text.ToUpper());
            string selectBooksQuery = $"SELECT ID, TITLE FROM BOOK WHERE TITLE LIKE '%{txt}%'";
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectBooksQuery, Common.SqlConnection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBooksResult.DataSource = dt;
            }

            

        }

        private void NewRental_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string usrName = Common.Sanitize(txtName.Text.ToUpper());
            string usrSurname = Common.Sanitize(txtSurname.Text.ToUpper());

            SqlCommand searchUser = new SqlCommand("SELECT ID, NAME, SURNAME FROM READER WHERE NAME = @name AND SURNAME = @surname", Common.SqlConnection);
            searchUser.Parameters.AddWithValue("@name", usrName);
            searchUser.Parameters.AddWithValue("@surname", usrSurname);

            using (SqlDataAdapter adapter = new SqlDataAdapter(searchUser))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUserResults.DataSource = dt;
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(dgvBooksResult[0, 0].Value);
            int userId = Convert.ToInt32(dgvUserResults[0, 0].Value);

            SqlCommand insertRental = new SqlCommand("INSERT INTO RENTALS VALUES (@book, @usr)", Common.SqlConnection);

            insertRental.Parameters.AddWithValue("@book", bookId);
            insertRental.Parameters.AddWithValue("@usr", userId);

            int result = insertRental.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Rental was finalized successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("An error occurred while trying to finalize a rental");
            }
        }
    }
}
