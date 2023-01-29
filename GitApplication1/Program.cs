namespace FcknGypsies
{


    class Program
    {
        static void Main(string[] args)
        {

        }
        public void MatrixB(int n, int m)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m - 1; ++j)
                {
                    if (i == j)
                        mass[i, j + 1] = i + j;
                }
            }
            for (int i = 0; i < n; ++i, Console.WriteLine())
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(mass[i, j] + " ");
                }
            }
        }
    }
}