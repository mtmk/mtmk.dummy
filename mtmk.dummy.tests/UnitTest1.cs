using Xunit.Abstractions;

namespace mtmk.dummy.tests;

public class UnitTest1(ITestOutputHelper @out)
{
    [Fact]
    public void Test1()
    {
        SimpleMaths simpleMaths = new();
        @out.WriteLine($"{simpleMaths.Add(1, 2)}");
        @out.WriteLine($"{Environment.Version}");
    }
}