using System;
using System.Collections.Generic;
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
            string MySQL_db;
            
            using (FileStream fs = new FileStream(MySQL_ini, FileMode.Open))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
            
                MySQL_db = System.Text.Encoding.Default.GetString(array);
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

        public List<Product> GetProducts()
        {
            //  Получить весь список
            List<Product> products = new List<Product>();

            string request = "SELECT * FROM table_product";
            _command.CommandText = request;

            var result = _command.ExecuteReader();

            while (result.Read())
            {
                int id = result.GetInt32("id");
                string name = result.GetString("name");
                string type = result.GetString("type_product");
                string color = result.GetString("color_product");
                int energy_value = result.GetInt32("energy_value");

                products.Add(new Product
                    { Id = id, Name = name, Type = type, Color = color, EnergyValue = energy_value });
            }

            return products;
        }

        public bool IsertProduct(Product product)
        {
            //  Добавление значения
            string request =
                $"INSERT INTO table_product (name, type_product, color_product, energy_value) VALUE ('{product.Name}','{product.Type}','{product.Color}','{product.EnergyValue}');";
            _command.CommandText = request;

            var result = _command.ExecuteNonQuery();

            return result > 0;
        }

        public List<string> GetNameProduct()
        {
            List<string> names = new List<string>();
            string request = "SELECT name FROM table_product;";
            _command.CommandText = request;

            MySqlDataReader result = _command.ExecuteReader();

            while (result.Read())
            {
                names.Add(result.GetString("name"));
            }

            return names;
        }

        public List<string> GetColorProduct()
        {
            List<string> colors = new List<string>();
            string request = "SELECT color_product FROM table_product;";
            _command.CommandText = request;

            MySqlDataReader result = _command.ExecuteReader();

            while (result.Read())
            {
                colors.Add(result.GetString("color_product"));
            }

            return colors;
        }

        public int GetMaxEnergyValue()
        {
            string request = "SELECT MAX(energy_value) as max FROM table_product;";
            // string request = "SELECT MAX(energy_value) FROM table_product;";
            _command.CommandText = request;

            MySqlDataReader result = _command.ExecuteReader();

            int value = 0;
            while (result.Read())
            {
                value  = result.GetInt32("max");
            }

            return value;

            // return result.GetInt32("max");
        }

        public int GetMinEnergyValue()
        {
            string request = "SELECT MIN(energy_value) as min FROM table_product;";
            _command.CommandText = request;

            MySqlDataReader result = _command.ExecuteReader();

            int value = 0;
            
            while (result.Read())
            {
                value  = result.GetInt32("min");
            }

            return value;
        }

        public decimal GetAvgEnergyValue()
        {
            string request = "SELECT AVG(energy_value) as avg FROM table_product;";
            _command.CommandText = request;

            MySqlDataReader result = _command.ExecuteReader();

            decimal value = 0;
            while (result.Read())
            {
                value  = result.GetDecimal("avg");
            }

            return value;

        }
    }
}