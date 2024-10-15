namespace _00_main_subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //! satır sonunda imleç aşağı geçer
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            //! satır sonunda imleç olduğu yerde kalır
            Console.Write("Hello, World!");
            Console.Write("Hello, World!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion



            #region String Değişkenler
            string name = "burak";
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine();

            string customerName = "burak";
            string customerSurname = "özcan";
            string customerPhone = "+90 555 555 5555";
            string customerEmail = "ozcanburakzafer@mail.com";
            string customerDistrict = "Çayırova";
            string customerCity = "Kocaeli";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email Adresi : " + customerEmail);
            Console.WriteLine("Adres : " + customerDistrict + "/" + customerCity);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            #endregion



            #region Int Değişkenler
            int number = 24;
            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine();

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran Menü Listesi *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger : " + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola : " + cokePrice + "TL");
            Console.WriteLine("-----Su : " + waterPrice + "TL");
            Console.WriteLine("-----Kızartma : " + friesPrice + "TL");
            Console.WriteLine("-----Pizza : " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata : " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Listesi *****");
            Console.WriteLine();

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice;
            Console.WriteLine("Toplam fiyat: " + totalPrice);


            #endregion


            Console.Read();
        }
    }
}