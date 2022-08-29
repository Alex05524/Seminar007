internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] TwoDimensionalArray = new int[3, 4];
        Random ran = new Random();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                TwoDimensionalArray[i, j] = ran.Next(1, 17);
                Console.Write("{0}\t", TwoDimensionalArray[i, j]);
            }
            Console.WriteLine();
        }
        void ReturnNumb()
        {
            int i = 17;
            int j = 17;
            if (i > 3 && j > 4)
            {
                Console.WriteLine($"17 -> такого числа в массиве нет");
                return;
            }
        }
        ReturnNumb();
    }
}