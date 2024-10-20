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



            #region  Dizi metotları
            string[] persons = { "burak", "zafer", "özcan" };
            Console.WriteLine(persons.Length);
            Console.WriteLine("-----------------------------");

            int[] numbers4 = { 45, 85, 52, 41, 86 };
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine("normal dizi : " + numbers4[i]);
            }
            Console.WriteLine("-----------------------------");

            Array.Sort(numbers4);
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine("sort ile dizi : " + numbers4[i]);
            }
            Console.WriteLine("-----------------------------");

            Array.Reverse(numbers4);
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine("sorttan sonra reverse ile dizi : " + numbers4[i]);
            }
            Console.WriteLine("-----------------------------");

            string[] customers = { "burak", "zafer", "özcan", "şevval" };
            int index = Array.IndexOf(customers, "zafer");
            Console.WriteLine(index);
            Console.WriteLine("-----------------------------");


            int[] numbers5 = { 1, 4, 2, 8, 6, 0, 98, 3 };
            Console.WriteLine("maksimum : " + numbers5.Max());
            Console.WriteLine("minimum : " + numbers5.Min());
            Console.WriteLine("-----------------------------");


            #endregion



            #region Kullanıcıdan değer almak
            string[] cities3 = new string[5];
            for (int i = 0; i < cities3.Length; i++)
            {
                Console.Write($"lütfen {i + 1}. şehri giriniz : ");
                cities3[i] = Console.ReadLine();
            }
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < cities3.Length; i++)
            {
                Console.WriteLine(cities3[i]);
            }
            Console.WriteLine("-----------------------------");

            #endregion


            #region dizideki tüm değerleri toplamak
            int[] numbers6 = { 12, 23, 34, 45, 56 };
            int sum = 0;
            for (int i = 0; i < numbers6.Length; i++)
            {
                sum += numbers6[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine("-----------------------------");

            #endregion


            #region Dizideki çift ve tek sayıları bulmak
            int[] numbers7 = { 12, 23, 34, 45, 56, 45, 23, 65, 879, 23, 56, 782, 3445, 13456, 1, 2543, 8743 };
            Console.WriteLine("çift sayılar : ");
            for (int i = 0; i < numbers7.Length; i++)
            {
                if (numbers7[i] % 2 == 0)
                {
                    Console.WriteLine(numbers7[i]);
                }
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("tek sayılar : ");
            for (int i = 0; i < numbers7.Length; i++)
            {
                if (numbers7[i] % 2 == 1)
                {
                    Console.WriteLine(numbers7[i]);
                }
            }
            Console.WriteLine("-----------------------------");

            #endregion
            Console.Read();
        }
    }
}
