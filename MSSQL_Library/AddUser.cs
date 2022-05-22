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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && tbSurname.Text != "")
            {
                SqlCommand insert = new SqlCommand("INSERT INTO READER VALUES (@name, @surname, @dob)", Common.SqlConnection);
                insert.Parameters.AddWithValue("@name", Common.Sanitize(tbName.Text.ToUpper()));
                insert.Parameters.AddWithValue("@surname", Common.Sanitize(tbSurname.Text.ToUpper()));
                insert.Parameters.AddWithValue("@dob", dtpDateBirth.Value);

                int success = insert.ExecuteNonQuery();
                if (success > 0)
                    MessageBox.Show("The reader was registered successfully!", "Insert OK");
                else
                    MessageBox.Show("An error occurred while trying to register the reader", "Error");

                Close();
            }
            else
            {
                MessageBox.Show("Can't have empty name or surname fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
