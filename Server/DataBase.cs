using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;
namespace Server
{
    class DataBase
    {
        private SQLiteConnection myConnection;

        public DataBase()
        {
            myConnection = new SQLiteConnection("Data Source=users.sqlite3");
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
