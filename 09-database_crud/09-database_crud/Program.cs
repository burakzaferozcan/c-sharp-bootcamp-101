using System.Data;
using Microsoft.Data.SqlClient;

namespace _09_database_crud
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // CRUD= Create-Read-Update-Delete
            Console.WriteLine("***** Meni Sipariş Paneli *****");
            
            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            #region (CREATE) Kategori Ekleme İşlemi
            // Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            // string categoryName = Console.ReadLine();
            //
            // SqlConnection connection = new SqlConnection("Server=localhost;Database=EgitimKampiDB;User Id=sa;Password=burak.88bb;TrustServerCertificate=True;");
            //
            // connection.Open();
            //
            // SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            // command.Parameters.AddWithValue("@p1", categoryName);
            //
            // command.ExecuteNonQuery();
            // connection.Close();
            // Console.WriteLine("Kategori Başarıyla Eklendi!");
            #endregion
           
            
            #region (CREATE) Ürün Ekleme İşlemi
            // Console.Write("Ürün Adı: ");
            // string productName = Console.ReadLine();
            // Console.Write("Ürün Fiyatı: ");
            // decimal productPrice =decimal.Parse(Console.ReadLine());
            // bool productStatus;
            //
            // SqlConnection connection = new SqlConnection("Server=localhost;Database=EgitimKampiDB;User Id=sa;Password=burak.88bb;TrustServerCertificate=True;");
            //
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();
            //
            // connection.Close();
            // Console.WriteLine("Ürün Başarıyla Eklendi!");
            #endregion

            
            #region (Read) Ürün Listeleme İşlemi
            SqlConnection connection = new SqlConnection("Server=localhost;Database=EgitimKampiDB;User Id=sa;Password=burak.88bb;TrustServerCertificate=True;");

            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblProduct",connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            connection.Close();
            #endregion

        }
    }
}