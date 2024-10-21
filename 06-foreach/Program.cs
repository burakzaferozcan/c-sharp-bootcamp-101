
namespace _06_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            string[] cities = { "ankara", "istanbuli", "kastamonu", "bursa", "trabzon", "manisa", "gaziantep" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("--------------------------");
            int[] numbers = { 1, 2, 09, 432, 84, 09328, 409238, 4, 435435, 67, 6, 23, 12, 5, 6, 7, 7, 8, 1, 9, 7, 6 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("--------------------------");

            int[] numbers2 = { 1, 2, 09, 432, 84, 09328, 409238, 4, 435435, 67, 6, 23, 12, 5, 6, 7, 7, 8, 1, 9, 7, 6 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);

                }
            }
            Console.WriteLine("--------------------------");

            int[] numbers3 = { 1, 2, 09, 432, 67, 6, 23, 12, 5, 6, 7, 7, 8, 1, 9, 7, 6 };
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;

            }
            Console.WriteLine(total);

            Console.WriteLine("--------------------------");

            List<int> numbers4 = new List<int>(){
                1,2,3,4,5,8
            };
            foreach (int number in numbers4)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("--------------------------");

            string word = "Burak";
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }


            #endregion

            Console.Read();
        }
    }
}