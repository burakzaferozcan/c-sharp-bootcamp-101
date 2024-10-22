
namespace _07_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye değer döndürmeyen parametresiz metotlar
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

            #region Geriye değer döndürmeyen parametreli metotlar
            void writeMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }
            string name = "zafer";
            writeMethod("burak");
            writeMethod(name);
            Console.WriteLine("-----------------------");

            void customerCard(string name, string surname)
            {
                Console.WriteLine(name + " " + surname);
            }
            string customerName = "Burak Zafer";
            string customerSurname = "Özcan";
            customerCard(customerName, customerSurname);
            Console.WriteLine("-----------------------");



            #endregion

            Console.Read();
        }
    }
}