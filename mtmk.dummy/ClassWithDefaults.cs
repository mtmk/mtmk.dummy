namespace mtmk.dummy;

public interface IClassWithDefaults
{
    int Sqr(int arg1);
}

public class ClassWithDefaults : IClassWithDefaults
{
    public int Sqr(int arg1)
    {
        return arg1 * arg1;
    }
}

public interface IClassWithOverloads
{
    int Sqr(int arg1);
}

public class ClassWithOverloads : IClassWithOverloads
{
    public int Sqr(int arg1)
    {
        return arg1 * arg1;
    }
}