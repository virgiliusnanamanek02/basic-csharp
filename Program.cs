internal class Program
{
    static int addTwoNumbers(int a, int b)
    {
        return a + b;
    }
    private static void Main(string[] args)
    {
        Person first = new Person
        {
            name = "John",
            age = 30
        };

        Console.WriteLine(first.Introduction());
        Console.WriteLine(first.Name);
        Console.WriteLine(first.Age);
    }
}
