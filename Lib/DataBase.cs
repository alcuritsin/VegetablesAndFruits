using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace Lib
{
    public class DataBase
    {
        private const string MySQL_ini = @"..\..\..\..\..\..\MySQL.ini"; //  Ключь от MySql :)
        private readonly MySqlConnection _db;
        private MySqlCommand _command;

        public DataBase()
        {
            using (FileStream fs = new FileStream(MySQL_ini, FileMode.Open))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);

                string MySQL_db = System.Text.Encoding.Default.GetString(array);
                _db = new MySqlConnection(MySQL_db);
            }

            _command = new MySqlCommand { Connection = _db };
        }

        public void Open()
        {
            _db.Open();
        }

        public void Close()
        {
            _db.Close();
        }
    }
}