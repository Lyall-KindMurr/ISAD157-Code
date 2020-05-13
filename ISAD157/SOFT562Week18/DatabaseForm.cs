using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace SOFT562Week18
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void comboBoxQueryChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQueryChoice.SelectedIndex == 0)
            {
                /////////////////////////////////////////////////////////////////
                //
                // The basic format of a connection string consists of a series
                // of keyword/value pairs separated by semicolons. The equal
                // sign (=) connects each keyword and its value. Specifically,
                // our connection string MUST refer to 
                // proj-mysql.uopnet.plymouth.ac.uk as the server, and
                // to our username and password to access
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                /////////////////////////////////////////////////////////////////

                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                ///////////////////////////////////////////////////////////////
                //
                // Create an open connection to a MySQL Server database. In our
                // case, the connection allows us to interact with
                // proj-mysql.uopnet.plymouth.ac.uk.
                //
                ///////////////////////////////////////////////////////////////

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    ///////////////////////////////////////////////////////////
                    //
                    // The query which retrieves all the records in the
                    // customers table.
                    //
                    ///////////////////////////////////////////////////////////
                    string query = "select * from isad157_scandea.users limit 6000";

                    ///////////////////////////////////////////////////////////
                    //
                    // Opens a database connection with the property settings
                    // specified by the ConnectionString.
                    //
                    ///////////////////////////////////////////////////////////
                    connection.Open();

                    ///////////////////////////////////////////////////////////
                    //
                    // Submit the SQL statement to be executed against the
                    // MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    ///////////////////////////////////////////////////////////
                    //
                    // The MySqlDataAdapter represents a set of data commands
                    // and a database connection that are used to fill a
                    // dataset and update a MySQL database.
                    //
                    ///////////////////////////////////////////////////////////
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable userDataTable = new DataTable();
                    sqlDA.Fill(userDataTable);

                    ///////////////////////////////////////////////////////////
                    //
                    // Bind the ACME customer table to the Data Grid View.
                    //
                    ///////////////////////////////////////////////////////////
                    dataGridViewAdministrator.DataSource = userDataTable;

                } // End of using (MySqlConnection connection = ...
            }


            else if (comboBoxQueryChoice.SelectedIndex == 1)
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    string query = "select * from isad157_scandea.friend limit 20000";

                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable friendDataTable = new DataTable();
                    sqlDA.Fill(friendDataTable);


                    dataGridViewAdministrator.DataSource = friendDataTable;
                }
            }


            else if (comboBoxQueryChoice.SelectedIndex == 2)
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    string query = "select * from isad157_scandea.message limit 20000";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable messageDataTable = new DataTable();
                    sqlDA.Fill(messageDataTable);

                    dataGridViewAdministrator.DataSource = messageDataTable;
                }
            }


            else if (comboBoxQueryChoice.SelectedIndex == 3)
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    string query = "select * from isad157_scandea.university limit 8000";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable universityDataTable = new DataTable();
                    sqlDA.Fill(universityDataTable);

                    dataGridViewAdministrator.DataSource = universityDataTable;
                }
            }


            else if (comboBoxQueryChoice.SelectedIndex == 4)
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {
                    string query = "select * from isad157_scandea.workplace limit 20000";

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable workplaceDataTable = new DataTable();
                    sqlDA.Fill(workplaceDataTable);

                    dataGridViewAdministrator.DataSource = workplaceDataTable;
                }
            } // end of ELSE string
        } // End of private void comboBoxQueryChoice_SelectedIndexChanged

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////
            //we read in all the datatables, store them in sepparate datatables, then we pick the information we need
            //////////////////////////////////////////////////////
            int RequestedId = -1;
            
            try
            {
                RequestedId = Convert.ToInt32(txtIDSearch.Text);
            }
            catch { }

            //first, we need to make sure the user input a correct value into the search field
            if (RequestedId>=0 && RequestedId<=5000)
            {
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "select * from isad157_scandea.users where UserID=" + RequestedId;

                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable universityDataTable = new DataTable();
                    sqlDA.Fill(universityDataTable);

                    txtID.Text = Convert.ToString(universityDataTable.Rows[0]["FirstName"] + "hello");
                }

                

            }
            else
            {
                MessageBox.Show("Incorrect Input type, please input a number between 1 and 5000");
            }
        } //end of Button click.
    }
}
