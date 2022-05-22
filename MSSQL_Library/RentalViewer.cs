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
    public partial class RentalViewer : Form
    {
        public RentalViewer()
        {
            InitializeComponent();
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            if (tbSearchString.Text.Contains("\"") || tbSearchString.Text.Contains(";"))
            {
                MessageBox.Show("Sanitization of input failed");
                return;
            }

            tbSearchString.Text = tbSearchString.Text.ToUpper();

            string query = "SELECT * FROM BOOK_RENTALS_COMPLETE ";
            if (radioExact.Checked)
                query += $"WHERE TITLE = '{tbSearchString.Text}'";
            else if (radioAnyBefore.Checked)
                query += $"WHERE TITLE LIKE '%{tbSearchString.Text}'";
            else if (radioAnyAfter.Checked)
                query += $"WHERE TITLE LIKE '{tbSearchString.Text}%'";
            else if (radioAnyBeforeAfter.Checked)
                query += $"WHERE TITLE LIKE '%{tbSearchString.Text}%'";

            //MessageBox.Show(query);

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Common.SqlConnection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvResults.DataSource = dt;
            }
        }
    }
}
