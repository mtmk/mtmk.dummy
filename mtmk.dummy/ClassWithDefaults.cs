namespace mtmk.dummy;

public interface IClassWithDefaults
{
    int Sqr(int arg1, bool arg2 = false);
}

public class ClassWithDefaults : IClassWithDefaults
{
    public int Sqr(int arg1, bool arg2 = false)
    {
        if (arg2)
            return (int)Math.Sqrt(arg1);

        return arg1 * arg1;
    }
}

public interface IClassWithOverloads
{
    int Sqr(int arg1);
    int Sqr(int arg1, bool arg2);
}

public class ClassWithOverloads : IClassWithOverloads
{
    public int Sqr(int arg1)
    {
        return arg1 * arg1;
    }

    public int Sqr(int arg1, bool arg2)
    {
        if (arg2)
            return (int)Math.Sqrt(arg1);
        
        return arg1 * arg1;
    }
}