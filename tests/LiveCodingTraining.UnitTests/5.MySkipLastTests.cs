using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class MySkipLastTests
{
    [Fact]
    public void MySkipLast_TwoElements_ReturnsFirstTwo_FromSourceTests()
    {
        var source = new[] { 1, 2, 3, 4 };
        var items = source.MySkipLast(2);
        Assert.True(items.SequenceEqual([1, 2]));
    }

    [Fact]
    public void MySkipLast_ZeroCount_ReturnsAll()
    {
        var source = new[] { 1, 2, 3, 4 };
        var items = source.MySkipLast(0);
        Assert.True(items.SequenceEqual(source));
    }

    [Fact]
    public void MySkipLast_CountGreaterThanLength_ReturnsEmpty()
    {
        var source = new[] { 1, 2, 3 };
        var items = source.MySkipLast(10);
        Assert.Empty(items);
    }
}
