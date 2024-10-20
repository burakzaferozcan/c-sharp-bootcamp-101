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


            #region Dizideki tüm elemanları döngü ile listeleme
            string[] colors2 = { "sarı", "kırmızı", "mavi", "yeşil", "turuncu", "pembe" };
            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }
            Console.WriteLine("-----------------------------");
            #endregion


            #region Dizideki 3'e tam bölünen elemanları döngü ile listeleme
            int[] number3 = { 1, 2, 09, 432, 84, 09328, 409238, 4, 435435, 67, 6, 23, 12, 5, 6, 7, 7, 8, 1, 9, 7, 6 };
            for (int i = 0; i < number3.Length; i++)
            {
                if (number3[i] % 3 == 0)
                {
                    Console.WriteLine(number3[i]);

                }
            }
            Console.WriteLine("-----------------------------");
            #endregion


            #region Char ile Dizi oluşturmak
            char[] characters = { 'b', 'u', 'r', 'a', 'k' };
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i]);
            }
            Console.WriteLine("-----------------------------");
            #endregion


            #region  Dizideki en büyük sayıyı bulmak
            int[] myArray = { 2, 6, 90, -45, 23, 6, -12, 45, 6, 82, 7678 };
            int maxNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {

                    maxNumber = myArray[i];

                }
            }
            Console.WriteLine(maxNumber);

            Console.WriteLine("-----------------------------");
            #endregion

            #region  Dizideki en büyük sayıyı bulmak
            int[] myArray2 = { 2, 6, 90, -45, 23, 6, -12, 45, 6, 82, 7678 };
            int minNumber = myArray2[0];
            for (int i = 0; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minNumber)
                {

                    minNumber = myArray2[i];

                }
            }
            Console.WriteLine(minNumber);

            Console.WriteLine("-----------------------------");
            #endregion


            Console.Read();
        }
    }
}
