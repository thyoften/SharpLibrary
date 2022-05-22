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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            numYear.Value = DateTime.Now.Year;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text != "" && tbAuthor.Text != "")
            {
                SqlCommand insert = new SqlCommand("INSERT INTO BOOK VALUES (@title, @author, @year, @qty)", Common.SqlConnection);
                insert.Parameters.AddWithValue("@title", Common.Sanitize(tbTitle.Text.ToUpper()));
                insert.Parameters.AddWithValue("@author", Common.Sanitize(tbAuthor.Text.ToUpper()));
                insert.Parameters.AddWithValue("@year", numYear.Value);
                insert.Parameters.AddWithValue("@qty", numAmt.Value);

                int success = insert.ExecuteNonQuery();
                if (success > 0)
                    MessageBox.Show("The book was added successfully!", "Insert OK");
                else
                    MessageBox.Show("An error occurred while trying to add the book", "Error");

                Close();

            }
            else
            {
                MessageBox.Show("Can't have empty title or author fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
