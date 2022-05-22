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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder.DataSource = "$INSTANCE"; //TODO: load from settings
            sqlStringBuilder.AttachDBFilename = "$FILEPATH";
            sqlStringBuilder.UserID = tbUser.Text;
            sqlStringBuilder.Password = mtbPassword.Text;
            try
            {
                Common.SqlConnection = new SqlConnection(sqlStringBuilder.ConnectionString);
                Common.SqlConnection.Open();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainForm mainFrm = new MainForm();
            mainFrm.Show();
            this.Hide();
        }
    }
}
