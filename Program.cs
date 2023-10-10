internal class Program
{
    private static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }

        Array.Sort(cars);
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }

        int[] myNumbers = { 5, 1, 8, 9 };
        Array.Sort(myNumbers);
        foreach (int i in myNumbers)
        {
            Console.WriteLine(i);
        }

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine(numbers[i, j]);
            }
        }
    }
}