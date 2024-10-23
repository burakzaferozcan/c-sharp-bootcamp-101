using System;
using System.Data;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace _08_database_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            Console.WriteLine("C# veritabanlı ürün-kategori bilgi sistemi");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("5-Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();

            Console.WriteLine("-----------------------------------------");
            string connectionString = "Server=localhost;Database=EgitimKampiDB;User ID=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM TblCategory", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                connection.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine();
                }
            }

            #endregion

            Console.Read();
        }
    }
}