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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #endregion


            #region Char değişkenler

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion


            #region Klavyeden string veri girişleri 
            Console.WriteLine("***** Csharop hava yolları yolcu bilgisi *****");
            Console.WriteLine();
            string customerName, customerSurname, customerDistrict, customerCity, customerAge, customerIdentitiyNumber;
            Console.Write("Yolcu Adı : ");
            customerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı : ");
            customerSurname = Console.ReadLine();
            Console.Write("Yolcu yaşadığı şehir : ");
            customerCity = Console.ReadLine();
            Console.Write("Yolcu yaşadığı ilçe : ");
            customerDistrict = Console.ReadLine();
            Console.Write("Yolcu yaşı : ");
            customerAge = Console.ReadLine();
            Console.Write("Yolcu TC kimlik numarası : ");
            customerIdentitiyNumber = Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Yolcu bilgileri : \n" + customerName + " " + customerSurname + " " + customerCity + " " + customerDistrict + " " + customerAge + " " + customerIdentitiyNumber);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #endregion



            #region Klavyeden integer veri girişleri 
            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            shoeCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            tvCount = int.Parse(Console.ReadLine());

            int shoeTotalPrice = shoePrice * shoeCount;
            int computerTotalPrice = computerPrice * computerCount;
            int chairTotalPrice = chairPrice * chairCount;
            int tvTotalPrice = tvPrice * tvCount;

            Console.WriteLine();
            Console.WriteLine("Satın alınan toplam ayakkabı fiyatı : " + shoeTotalPrice);
            Console.WriteLine("Satın alınan toplam bilgisayar fiyatı : " + computerTotalPrice);
            Console.WriteLine("Satın alınan toplam sandalye fiyatı : " + chairTotalPrice);
            Console.WriteLine("Satın alınan toplam televizyon fiyatı : " + tvTotalPrice);

            int totalPrice = shoeTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;
            Console.WriteLine("Alışveriş Toplamı : " + totalPrice);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            #endregion


            Console.Read();
        }
    }
}