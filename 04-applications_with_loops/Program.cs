namespace _04_applications_with_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 yıldız oluşturmak
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("---------------------");

            #endregion

            #region Yan yana 10 yıldız oluşturmak
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("---------------------");

            #endregion

            #region Alt alta 10 yıldız oluşturma her satırda 10 yıldız oluşturmak
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }
            Console.WriteLine("---------------------");

            #endregion

            #region Yıldızlarla dik üçgen oluşturmak
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("---------------------");
            #endregion

            #region Yıldızlarla ters dik üçgen oluşturmak
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("---------------------");
            #endregion

            #region Yıldızlarla dik ve ters dik üçgen oluşturmak
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine("---------------------");
            #endregion


            #region Piramit oluşturmak
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine("---------------------");
            #endregion


            #region Ters piramit oluşturmak
            int m = 5;
            for (int i = m; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine("---------------------");
            #endregion
            Console.Read();
        }
    }
}
