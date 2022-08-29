internal partial class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = random.Next(1, 10);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Среднее арифметическое:");
        for (int j = 0; j < 4; j++)
        {
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += array[i, j];
            }
            Console.Write($"{sum / 4}{";"} ");
        }
    }
}