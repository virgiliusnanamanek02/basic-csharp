internal class Program
{
    static int addTwoNumbers(int a, int b)
    {
        return a + b;
    }
    private static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            name = "John",
            age = 30
        };

        string employeeIntroduction = employee.Introduction();
        Console.WriteLine(employeeIntroduction);

        Person person = new Person
        {
            name = "Alice",
            age = 25
        };

        string personIntroduction = person.Introduction();
        Console.WriteLine(personIntroduction);    }
}
