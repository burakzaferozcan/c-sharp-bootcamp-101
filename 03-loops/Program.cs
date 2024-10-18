
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
            Console.WriteLine("------------------------");

            #endregion



            #region For Döngüsü Örnek
            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ". saat sonunda bakteri sayısı : " + bacterium);
            }
            Console.WriteLine("------------------------");

            #endregion


            #region While Döngüsü
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("Merhaba while döngüsü");
                j++;
            }
            Console.WriteLine("------------------------");

            #endregion


            #region While Döngüsü Karar Yapıları
            int k = 1;
            while (k <= 10)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
            Console.WriteLine("------------------------");

            int l = 1;
            int sum = 0;
            while (l <= 10)
            {
                sum += l;
                l++;
            }
            Console.WriteLine(sum);
            Console.WriteLine("------------------------");

            #endregion

            #region Örnek Sınav Sorusu
            //! Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan programı yazınız.
            Console.Write("Sayıyı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sumExam;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            sumExam = ones + tens + hundreds;
            Console.WriteLine("Birler basamağı : " + ones);
            Console.WriteLine("Onlar basamağı : " + tens);
            Console.WriteLine("Yüzler basamağı : " + hundreds);
            Console.WriteLine("Basamaklar toplamı : " + sumExam);


            #endregion

            Console.Read();
        }
    }
}