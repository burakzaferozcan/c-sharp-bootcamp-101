
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
            #endregion

            Console.Read();
        }
    }
}