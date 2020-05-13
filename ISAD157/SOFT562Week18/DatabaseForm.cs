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
                    DataTable UserDataTable = new DataTable();
                    sqlDA.Fill(UserDataTable);

                    //filling in the fields regarding the user's general data

                    txtID.Text = Convert.ToString(UserDataTable.Rows[0]["UserID"]);
                    txtfirstname.Text = Convert.ToString(UserDataTable.Rows[0]["FirstName"]);
                    txtlastname.Text = Convert.ToString(UserDataTable.Rows[0]["LastName"]);
                    txtgender.Text = Convert.ToString(UserDataTable.Rows[0]["Gender"]);
                    txtrelationship.Text = Convert.ToString(UserDataTable.Rows[0]["Relationship"]);
                    txthometown.Text = Convert.ToString(UserDataTable.Rows[0]["Hometown"]);
                    txtcity.Text = Convert.ToString(UserDataTable.Rows[0]["City"]);

                    //filling in the Universities and workplaces database viewers.

                    query = "select * from isad157_scandea.university where UserID=" + RequestedId;

                    cmd = new MySqlCommand(query, connection);

                    sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UniversityDataTable = new DataTable();
                    sqlDA.Fill(UniversityDataTable);

                    dataGridViewUniversities.DataSource = UniversityDataTable;

                    //and now the workplace.. just copypaste that over, change 4 words..

                    query = "select * from isad157_scandea.workplace where UserID=" + RequestedId;

                    cmd = new MySqlCommand(query, connection);

                    sqlDA = new MySqlDataAdapter(cmd);
                    DataTable WorkplaceDataTable = new DataTable();
                    sqlDA.Fill(WorkplaceDataTable);

                    dataGridViewWorkplaces.DataSource = WorkplaceDataTable;

                    //good, that went smooth, now let's create some custom listbox messages..
                    //this will not be fun, but I hope the aspect will be better than just displaying the datatable.

                    lstfriends.Items.Clear();
                    lstmessages.Items.Clear();//for multiple searches, not to pile up.

                    query = "select UserID2 from isad157_scandea.friend where UserID1=" + RequestedId;

                    cmd = new MySqlCommand(query, connection);

                    sqlDA = new MySqlDataAdapter(cmd);
                    DataTable FriendDataTable = new DataTable();
                    sqlDA.Fill(FriendDataTable);

                    //we have a list of the User's friends ID-s in a datatable, now we extract the names from the users table.

                    foreach(DataRow friendID in FriendDataTable.Rows)
                    {
                        query = "select FirstName,Lastname from isad157_scandea.users where UserID=" + Convert.ToString(friendID[0]);

                        cmd = new MySqlCommand(query, connection);

                        sqlDA = new MySqlDataAdapter(cmd);
                        DataTable TempFriendDataTable = new DataTable();
                        sqlDA.Fill(TempFriendDataTable);

                        lstfriends.Items.Add(Convert.ToString(TempFriendDataTable.Rows[0]["FirstName"]) + " " + Convert.ToString(TempFriendDataTable.Rows[0]["LastName"]));

                    }



                    //and now the same thing for messages.
                    //first messages sent by the user

                    query = "select * from isad157_scandea.message where UserID1=" + RequestedId;

                    cmd = new MySqlCommand(query, connection);

                    sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessageDataTable = new DataTable();
                    sqlDA.Fill(MessageDataTable);

                    foreach (DataRow FriendRow in MessageDataTable.Rows)
                    {
                        query = "select FirstName,Lastname from isad157_scandea.users where UserID=" + Convert.ToString(FriendRow[1]);

                        cmd = new MySqlCommand(query, connection);

                        sqlDA = new MySqlDataAdapter(cmd);
                        DataTable FriendNameDataTable = new DataTable();
                        sqlDA.Fill(FriendNameDataTable);

                        string FriendName = Convert.ToString(FriendNameDataTable.Rows[0]["FirstName"]) + " " + Convert.ToString(FriendNameDataTable.Rows[0]["LastName"]);
 
                        string DateTimemsg = Convert.ToString(FriendRow[2]);
                        string FriendMessage = Convert.ToString(FriendRow[3]);

                        lstmessages.Items.Add("To: " + FriendName + " at: " + DateTimemsg + " Message:" + FriendMessage);
                    }

                    //and now the Messages received


                    query = "select * from isad157_scandea.message where UserID2=" + RequestedId;

                    cmd = new MySqlCommand(query, connection);

                    sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessageReceivedDataTable = new DataTable();
                    sqlDA.Fill(MessageReceivedDataTable);

                    foreach(DataRow FriendRow in MessageReceivedDataTable.Rows)
                    {
                        query = "select FirstName,Lastname from isad157_scandea.users where UserID=" + Convert.ToString(FriendRow[1]);

                        cmd = new MySqlCommand(query, connection);

                        sqlDA = new MySqlDataAdapter(cmd);
                        DataTable FriendNameDataTable = new DataTable();
                        sqlDA.Fill(FriendNameDataTable);

                        string FriendName = Convert.ToString(FriendNameDataTable.Rows[0]["FirstName"]) + " " + Convert.ToString(FriendNameDataTable.Rows[0]["LastName"]);

                        string DateTimemsg = Convert.ToString(FriendRow[2]);
                        string FriendMessage = Convert.ToString(FriendRow[3]);

                        lstmessages.Items.Add("From: " + FriendName + " at: " + DateTimemsg + " Message:" + FriendMessage);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Input type, please input a number between 1 and 5000");
            }
        } //end of Button click.
    }
}
