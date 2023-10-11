public class Person
{
    public string? name;
    public int age;

    public virtual string Introduction(){
        return $"Halo, saya {name} dan saya berumur {age} tahun.";
    }

    public virtual string? Name => name;

    public virtual int Age => age;
}


public class Employee: Person
{
    public override string Introduction(){
        return $"Halo, saya {name} dan saya adalah seorang karyawan berumur {age} tahun.";
    }

    public override string? Name => base.Name;

    public override int Age => base.Age;
}
