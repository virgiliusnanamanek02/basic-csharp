internal class Program
{
    private static void Main(string[] args)
    {
        int age = 23;
        string name = "Nana";
        double salary = 3000.50;
        bool isStudent = true;

        if(isStudent){
            Console.WriteLine($"Hello, my name is {name} and I am {age} years old!");
        }else{
            Console.WriteLine($"My salary is {salary} per month!");
        }
    }
}