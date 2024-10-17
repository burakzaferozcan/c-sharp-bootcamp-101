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
            Console.Write("Lütfen şehir girişi yapınız : ");
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

            #region Örnek Uygulama
            Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");

            string menuItem;
            Console.WriteLine("Detayını görmek istediğiniz menüyü seçin : ");
            menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                Console.WriteLine("Ana Yemekler");
                Console.WriteLine("1-tavuk");
                Console.WriteLine("2-kızartma");
                Console.WriteLine("3-fasulye");
                Console.WriteLine("4-somon");
                Console.WriteLine("5-musakka");
            }
            else if (menuItem == "2")
            {
                Console.WriteLine("çorbalar");
                Console.WriteLine("1-tarhana");
                Console.WriteLine("2-mercimek");
                Console.WriteLine("3-kellepaça");
                Console.WriteLine("4-işkembe");
                Console.WriteLine("5-domates");
            }
            else if (menuItem == "3")
            {
                Console.WriteLine("Pizzalar");
                Console.WriteLine("1-karışık");
                Console.WriteLine("2-peynirli");
                Console.WriteLine("3-pastırmalı");
                Console.WriteLine("4-sucuklu");
                Console.WriteLine("5-yeşillikli");
            }
            else if (menuItem == "4")
            {
                Console.WriteLine("İçecekler");
                Console.WriteLine("1-fanta");
                Console.WriteLine("2-kola");
                Console.WriteLine("3-ayran");
                Console.WriteLine("4-su");
            }
            else if (menuItem == "5")
            {
                Console.WriteLine("Tatlılar");
                Console.WriteLine("1-baklava");
                Console.WriteLine("2-sufle");
                Console.WriteLine("3-künefe");
                Console.WriteLine("4-tiramisu");
                Console.WriteLine("5-kazandibi");
            }

            #endregion



            #region Switch Case
            Console.Write("Lütfen ay girişi yapınız : ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Ağustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    break;
            }
            #endregion


            #region Hesap Makinesi
            int calculateNumber1, calculateNumber2, calculateResult;
            char calculateSymbol;
            Console.Write("1. sayıyı giriniz : ");
            calculateNumber1 = int.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            calculateNumber2 = int.Parse(Console.ReadLine());
            Console.Write("yapmak istediğiniz işlemi giriniz (+,-,*,/) : ");
            calculateSymbol = char.Parse(Console.ReadLine());
            switch (calculateSymbol)
            {
                case '+':
                    calculateResult = calculateNumber1 + calculateNumber2;
                    Console.WriteLine("Cevap : " + calculateResult);
                    break;

                case '-':
                    calculateResult = calculateNumber1 - calculateNumber2;
                    Console.WriteLine("Cevap : " + calculateResult);
                    break;
                case '*':
                    calculateResult = calculateNumber1 * calculateNumber2;
                    Console.WriteLine("Cevap : " + calculateResult);
                    break;
                case '/':
                    calculateResult = calculateNumber1 + calculateNumber2;
                    Console.WriteLine("Cevap : " + calculateResult);
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz");
                    break;
            }

            #endregion

            Console.Read();


        }
    }
}