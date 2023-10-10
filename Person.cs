public class Person
{
    public string? name;
    public int age;

    public string Introduction(){
        return $"Halo, saya {name} dan saya berumur {age} tahun.";
    }

    public string? Name => name;

    public int Age => age;
}
