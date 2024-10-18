
namespace _03_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("" + i);
            }
            Console.WriteLine("------------------------");

            for (int i = 3; i <= 50; i += 3)
            {
                Console.WriteLine("" + i);
            }
            Console.WriteLine("------------------------");

            Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            int finishValue = int.Parse(Console.ReadLine());
            for (int i = 0; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Şeriat!");
            }
            Console.WriteLine("------------------------");

            #endregion



            #region For Döngüsü ile Karar Yapıları
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("------------------------");
            int totalValue = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("toplam : " + totalValue);
            Console.WriteLine("------------------------");


            int count = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("count değeri adedi : " + count);

            #endregion

            Console.Read();
        }
    }
}