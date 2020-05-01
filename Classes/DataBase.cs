using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace FacebookUI
{
    public class DataBase
    {
        private static readonly string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";
        public static string errorMsg;

        public static async Task<List<String>> getUserProfile(int ID)
        {
            List<String> result = null;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE userID = " + ID.ToString() + ";";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    await Task.Run(async () =>
                    {
                        var reader = await cmd.ExecuteReaderAsync();
                        reader.Read();
                        result = new List<String>
                        {
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6),

                        };
                    });
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return result;
        }

        public static async Task<DataTable> getWorkplaces(int ID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Workplaces.workplaceName AS \"Workplace Name\", Workers.dateStarted \"Date Started\", ifnull(Workers.dateLeft, 'Present') AS \"Date Left\" FROM Workers " +
                        "INNER JOIN Workplaces ON Workplaces.workplaceID = Workers.workplaceID WHERE userID = " + ID.ToString() + ";";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable workplaceTable = new DataTable("Workplace Data");

                    sqlDA.Fill(workplaceTable);
                    return workplaceTable;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }

        public static async Task<DataTable> getUniversities(int ID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Universities.universityName AS \"University Name\", Students.dateStarted \"Date Started\", ifnull(Students.dateLeft, 'Present') AS \"Date Left\" From Students " +
                        "INNER JOIN Universities ON Universities.uniID = Students.uniID WHERE userID = " + ID.ToString() + ";";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable uniTable = new DataTable("Universities Data");

                    sqlDA.Fill(uniTable);
                    return uniTable;
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }

        public static async Task<Boolean> updateUserInfo(String[] info, int userID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    String[] escapedInfo = new string[info.Length];
                    for(int i = 0; i < escapedInfo.Length; i++)
                    {
                        escapedInfo[i] = Util.EscapeSql(info[i]);
                    }
                    string query = "UPDATE Users SET firstName=@firstName, lastName=@lastName, gender=@gender,homeTown=@homeTown, currentCity=@currentCity," +
                        " relationshipStatus=@relationshipStatus WHERE userID=@userID";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@firstName", info[0]);
                    cmd.Parameters.AddWithValue("@lastName", info[1]);
                    cmd.Parameters.AddWithValue("@gender", Byte.Parse(info[2]));
                    cmd.Parameters.AddWithValue("@homeTown", info[3]);
                    cmd.Parameters.AddWithValue("@currentCity", info[4]);
                    cmd.Parameters.AddWithValue("@relationshipStatus", Byte.Parse(info[5]));
                    cmd.Parameters.AddWithValue("@userID", userID);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }

        public static async Task<String> getNumFriends(int userID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT COUNT(userID_2) FROM friendships WHERE userID_1 = " + userID + ";";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    DbDataReader reader = null;
                    await Task.Run(async () =>
                    {
                        reader = await cmd.ExecuteReaderAsync();
                        reader.Read();
                    });
                    return reader.GetString(0);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return "0";
        }

        public static async Task<DataTable> getUserFriends(int userID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    //Get all of the user's 
                    string query = "SELECT users.firstName AS 'First Name', users.lastName AS 'Last Name', users.userID AS 'User ID' FROM users " +
                        "INNER JOIN friendships ON friendships.userID_2 = users.userID WHERE friendships.userID_1 =" + userID + ";";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable uniTable = new DataTable("Friendship Data");

                    sqlDA.Fill(uniTable);
                    return uniTable;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }

        public static async Task<bool> removeFriend(int userID, int friendID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Friendships WHERE userID_1=@userID AND userID_2 =@friendID ;" +
                        "DELETE FROM Friendships WHERE userID_1=@friendID AND userID_2=@userID;";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@friendID", friendID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }

        public static async Task<bool> addFriend(int userID, int friendID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO friendships(userID_1, userID_2) VALUES ((SELECT userID FROM Users WHERE userID=@friendID), (SELECT userID FROM Users WHERE userID=@userID));" +
                        "INSERT INTO friendships(userID_1, userID_2) VALUES ((SELECT userID FROM Users WHERE userID=@userID), (SELECT userID FROM Users WHERE userID=@friendID));";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@friendID", friendID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }

        public static async Task<DataTable> getMessages(int userID, int viewID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    //Get all of the user's 
                    string query = "select * FROM Messages WHERE (senderID = @userID AND recipientID = @viewID) OR" +
                        " (senderID = @viewID AND recipientID = @userID) ORDER BY sentTime;";
                    if (con.State != System.Data.ConnectionState.Open)
                        await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@viewID", viewID);
                    DataTable dataTable = new DataTable("Message Data");
                    dataTable.Columns.Add("Message recieved");
                    dataTable.Columns.Add("Message sent");
                    var reader = await cmd.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        String[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        if(int.Parse(row[0]) == viewID)
                        {
                            dataTable.Rows.Add(row[3], " ");
                            dataTable.Rows.Add("Recieved at "+ row[2], " ");
                        }
                        else
                        {
                            dataTable.Rows.Add("   ", row[3]);
                            dataTable.Rows.Add(" ", "Sent at " + row[2]);
                        }
                    }
                    return dataTable;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }
        public static async Task<List<String[]>> findUserIDByName(string[] searchText)
        {
            List<String[]> result = new List<String[]>();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    //Select all profiles
                    MySqlCommand cmd = null;
                    if (searchText.Length == 1)
                    {
                        //Search for entries that match first name or last name as the user has only searched for two things
                        string query = "SELECT userID AS 'User ID', firstName AS 'First Name', lastName AS 'Last Name' FROM users WHERE firstName=@firstName OR lastName=@lastName";
                        if (con.State != System.Data.ConnectionState.Open)
                            await con.OpenAsync();
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@firstName", Util.UppercaseFirst(searchText[0].ToLower()));
                        cmd.Parameters.AddWithValue("@lastName", Util.UppercaseFirst(searchText[0].ToLower()));
                    }
                    else
                    {
                        string query = "SELECT userID AS 'User ID', firstName AS 'First Name', lastName AS 'Last Name' FROM users WHERE firstName=@firstName AND lastName=@lastName";
                        if (con.State != System.Data.ConnectionState.Open)
                            await con.OpenAsync();
                        cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@firstName", Util.UppercaseFirst(searchText[0].ToLower()));
                        cmd.Parameters.AddWithValue("@lastName", Util.UppercaseFirst(searchText[1].ToLower()));
                    }
                    var reader = await cmd.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        result.Add(new String[] { reader.GetString(0), reader.GetString(1), reader.GetString(2) });
                    };
                    con.Close();
                    return result;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return null;
        }

        public static async Task<bool> areFriends(int id1, int id2)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT EXISTS(SELECT * FROM friendships WHERE userID_1=@user1 AND userID_2=@user2);";
                    //await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user1", id1); 
                    cmd.Parameters.AddWithValue("@user2", id2);

                    await con.OpenAsync();
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    return reader.GetBoolean(0);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }

        public static async Task<bool> sendMessage(string text, int userID, int viewID)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Messages(senderID, recipientID, sentTime, messageText) VALUES(" +
                        "(SELECT userID FROM users WHERE userID=@userID)," +
                        "(SELECT userID FROM users WHERE userID=@viewID)," +
                        "@time, @text)";
                    await con.OpenAsync();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@viewID", viewID);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.Parameters.AddWithValue("@text", Util.EscapeSql(text));

                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return false;
        }
        public static async Task<bool> testConnection()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    await con.OpenAsync();
                    return true;
                }
                catch (MySqlException e)
                {
                    if (e.Number == 1042)
                    {
                        errorMsg = "Could not connect to databse";
                        DialogResult dialogResult = MessageBox.Show(errorMsg, "ERROR 1042", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                            return await testConnection();
                        else
                            return false;
                    }
                    else if (e.Number == 0)
                    {
                        errorMsg = "Databse access denied";
                        DialogResult dialogResult = MessageBox.Show(errorMsg, "ERROR 0", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                            return await testConnection();
                        else
                            return false;
                    }
                    else
                    {
                        MessageBox.Show("Could not connect to databse", "ERROR", MessageBoxButtons.RetryCancel);
                        DialogResult dialogResult = MessageBox.Show("ERROR 0: Databse access denied ", "caption", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                            return await testConnection();
                        else
                            return false;
                    }

                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
