using System.Data;
using Microsoft.Data.SqlClient;

namespace _08_database_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------");

            // SQL Bağlantısı
            SqlConnection connection = new SqlConnection("Server=localhost;Database=EgitimKampiDB;User Id=sa;Password=burak.88bb;TrustServerCertificate=True;");
            // SQL bağlantısı açılır.
            connection.Open();
            // SQL'de kullanılacak sorgu buraya yazılır.
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            // C# tarafında oluşturulan sorgu ile SQL arasında köprü görevi görür.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            // Veri tablolarını hafızada tutmak için ve üzerinde işlem yapmak için kullanılır.
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            // SQL bağlantısı kapatılır.
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();
        }
    }
}