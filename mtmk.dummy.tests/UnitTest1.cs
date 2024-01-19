using Xunit.Abstractions;

namespace mtmk.dummy.tests;

public class UnitTest1(ITestOutputHelper @out)
{
    [Fact]
    public void Test1()
    {
        @out.WriteLine($"{Environment.Version}");
    }
}