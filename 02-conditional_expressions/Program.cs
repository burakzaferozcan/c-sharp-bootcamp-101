using System.Globalization;

namespace _02_condintional_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            Console.Write("Lütfen şifreyi giriniz : ");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre doğru");
            }
            else
            {
                Console.WriteLine("Şifre yanlış");
            }

            string capital, country;
            Console.Write("Başkenti giriniz : ");
            capital = Console.ReadLine();
            Console.Write("Ülkeyi giriniz : ");
            country = Console.ReadLine();
            if (capital == "ankara" & country == "türkiye")
            {
                Console.WriteLine("Bilgiler doğrulandı");

            }
            else
            {
                Console.WriteLine("Hatalı bilgi");
            }

            int number;
            Console.Write("Sayıyı giriniz : ");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı doğru");

            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }

            int exam1, exam2, exam3, average;
            string result;
            Console.Write("Sınav 1 : ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Sınav 2 : ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav 3 : ");
            exam3 = int.Parse(Console.ReadLine());
            average = (exam1 + exam2 + exam3) / 3;
            if (average >= 0 & average < 50)
            {
                result = "Kaldı";
                Console.WriteLine("Sınavların ortalaması : " + average);
                Console.WriteLine(result);
            }
            else if (average >= 50 & average <= 70)
            {
                result = "Geçti";
                Console.WriteLine("Sınavların ortalaması : " + average);
                Console.WriteLine(result);

            }
            else if (average > 70 & average <= 100)
            {
                result = "Çok iyi";
                Console.WriteLine("Sınavların ortalaması : " + average);
                Console.WriteLine(result);

            }
            else
            {
                result = "Geçerli değerler giriniz (0-100 arası)";
                Console.WriteLine(result);
            }

            string city;
            Console.Write("Lütfen şehir girişi yapınız.");
            city = Console.ReadLine();
            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzone")
            {
                Console.WriteLine("Şehir mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");

            }

            #endregion

            #region Mod İşlemleri
            Console.Write("Lütfen 1. sayıyı giriniz : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz : ");
            int number2 = int.Parse(Console.ReadLine());
            int numberResult = number1 % number2;
            Console.WriteLine("1. sayının 2. sayıya bölümünden kalan : " + numberResult);

            Console.Write("Lütfen tek mi çift mi oldugunu kontrol edeceğiniz sayıyı giriniz : ");
            int evenOrOddNumber = int.Parse(Console.ReadLine());
            if (evenOrOddNumber % 2 == 0)
            {
                Console.WriteLine("sayı çift");
            }
            else
            {
                Console.WriteLine("sayı tek");

            }
            #endregion




            #region Char değişkenler ile karar yapıları
            char team;
            Console.Write("lütfen takım sembolünü giriniz : ");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            else if (team == 'f' | team == 'f')
            {
                Console.WriteLine("Fenerbahçe");
            }
            else if (team == 'b' | team == 'b')
            {
                Console.WriteLine("Beşiktaş");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sembol giriniz");
            }

            #endregion

            Console.Read();


        }
    }
}