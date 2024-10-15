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

            Console.Read();
        }
    }
}