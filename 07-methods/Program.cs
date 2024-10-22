
using System.Globalization;

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

            #region Geriye değer döndürmeyen string parametreli metotlar
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

            #region Geriye değer döndürmeyen integer parametreli metotlar

            void sum2(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            sum2(10, 20, 30);

            Console.WriteLine("-----------------------");
            #endregion


            #region Geriye değer döndüren parametresiz metotlar
            string CustomerName()
            {
                return "burak";
            }
            CustomerName();
            Console.WriteLine(CustomerName());
            Console.WriteLine("-----------------------");

            string StudentCard()
            {
                string name = "burak";
                string surName = "özcan";
                return name + " " + surName;
            }
            Console.WriteLine(StudentCard());
            string student = StudentCard();
            Console.WriteLine(student);
            Console.WriteLine("-----------------------");

            #endregion

            Console.Read();
        }
    }
}