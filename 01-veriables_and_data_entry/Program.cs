namespace _01_veriables_and_data_entry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler

            double number = 12.8;
            Console.WriteLine(number);
            Console.WriteLine();

            Console.WriteLine("***** Fiyat Listesi *****");
            double applePrice = 10.45;
            double orangePrice = 25.50;
            double strawberryPrice = 28.90;
            double potatoPrice = 8.25;
            double tomatoPrice = 8.0;
            Console.WriteLine("----- Emla Birim Fiyatı : " + applePrice + "TL");
            Console.WriteLine("----- Portakal Birim Fiyatı : " + orangePrice + "TL");
            Console.WriteLine("----- Çilek Birim Fiyatı : " + strawberryPrice + "TL");
            Console.WriteLine("----- Patates Birim Fiyatı : " + potatoPrice + "TL");
            Console.WriteLine("----- Domates Birim Fiyatı : " + tomatoPrice + "TL");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 4.890;
            potatoGram = 0.750;
            tomatoGram = 3.450;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Elma Toplam Fiyatı: " + appleTotalPrice + "TL");
            Console.WriteLine("Portakal Toplam Fiyatı: " + orangeTotalPrice + "TL");
            Console.WriteLine("Çilek Toplam Fiyatı: " + strawberryTotalPrice + "TL");
            Console.WriteLine("Patates Toplam Fiyatı: " + potatoTotalPrice + "TL");
            Console.WriteLine("Domates Toplam Fiyatı: " + tomatoTotalPrice + "TL");


            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine("Alışveriş Toplam Ödenecek Tutar: " + shoppingTotalPrice + "TL");

            #endregion
            Console.Read();
        }
    }
}