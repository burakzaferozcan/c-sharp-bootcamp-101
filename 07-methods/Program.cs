﻿
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



            #region Geriye değer döndüren string parametreli metotlar
            string CountryCard(string countryName, string capital, string flagColor)
            {
                return "Ülke : " + countryName + "\nBaşkent : " + capital + "\nBayrak rengi :  " + flagColor;
            }
            string country1 = CountryCard("türkiye", "ankara", "kırmızı-beyaz");
            string country2 = CountryCard("fransa", "paris", "lacivert-beyaz-kırmızı");
            Console.WriteLine(country1);
            Console.WriteLine(country2);
            Console.WriteLine("-----------------------");


            Console.Write("ülke adını giriniz : ");
            string countryName = Console.ReadLine();
            Console.Write("ülke başkentini giriniz : ");
            string countryCapital = Console.ReadLine();
            Console.Write("ülke bayrak rengini giriniz : ");
            string countryFlagColor = Console.ReadLine();
            string country3 = CountryCard(countryName, countryCapital, countryFlagColor);
            Console.WriteLine(country3);

            Console.WriteLine("-----------------------");

            #endregion

            #region Geriye değer döndüren integer parametreli metotlar

            int Sum3(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum3(45, 80));
            Console.WriteLine(Sum3(2, 812));
            Console.WriteLine(Sum3(4, 2));
            Console.WriteLine(Sum3(123, 42));
            Console.WriteLine("-----------------------");

            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return studentName + " Öğrenci sınavi geçti. Ortalama : " + result;
                }
                else
                {
                    return studentName + " Öğrenci sınavdan kaldı. Ortalama : " + result;
                }
            }
            Console.WriteLine(ExamResult("burak", 2, 3, 4));
            Console.WriteLine(ExamResult("burak", 80, 90, 100));

            Console.WriteLine("-----------------------");

            #endregion

            Console.Read();
        }
    }
}