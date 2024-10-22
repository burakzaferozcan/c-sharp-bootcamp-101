
namespace _07_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            void CustomerList()
            {
                Console.WriteLine("burak");
                Console.WriteLine("zafer");
                Console.WriteLine("özcan");
            }
            CustomerList();
            Console.WriteLine("-----------------------");

            void sum()
            {
                int x = 1;
                int y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }
            sum();
            Console.WriteLine("-----------------------");

            #endregion

            Console.Read();
        }
    }
}