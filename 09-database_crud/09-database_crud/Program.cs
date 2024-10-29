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
            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            decimal productPrice =decimal.Parse(Console.ReadLine());
            bool productStatus;
            
            SqlConnection connection = new SqlConnection("Server=localhost;Database=EgitimKampiDB;User Id=sa;Password=burak.88bb;TrustServerCertificate=True;");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);
            command.ExecuteNonQuery();
            
            connection.Close();
            Console.WriteLine("Ürün Başarıyla Eklendi!");

            #endregion

        }
    }
}