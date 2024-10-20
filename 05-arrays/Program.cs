namespace _05_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            string[] colors = new string[4];
            colors[0] = "sarı";
            colors[1] = "kırmızı";
            colors[2] = "beyaz";
            colors[3] = "yeşil";
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
            Console.WriteLine(colors[3]);
            Console.WriteLine("-----------------------------");

            string[] cities = new string[5];
            cities[0] = "milano";
            cities[1] = "budapeşte";
            cities[2] = "lyon";
            cities[3] = "ankara";
            cities[4] = "kahire";
            Console.WriteLine(cities[4]);
            Console.WriteLine("-----------------------------");

            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[4] = 748;

            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine("-----------------------------");


            string[] cities2 = { "prag", "istanbul", "roma", "atina" };
            Console.WriteLine(cities2[2]);
            Console.WriteLine("-----------------------------");

            #endregion

            Console.Read();
        }
    }
}
