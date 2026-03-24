using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class MyTakeLastTests
{
    [Fact]
    public void MyTakeLast_TwoElements_ReturnsLastTwo_FromSourceTests()
    {
        var source = new[] { 1, 2, 3, 4 };
        var items = source.MyTakeLast(2);
        Assert.True(items.SequenceEqual([3, 4]));
    }

    [Fact]
    public void MyTakeLast_ZeroCount_ReturnsEmpty()
    {
        var source = new[] { 1, 2, 3, 4 };
        var items = source.MyTakeLast(0);
        Assert.Empty(items);
    }

    [Fact]
    public void MyTakeLast_CountGreaterThanLength_ReturnsAll()
    {
        var source = new[] { 1, 2, 3 };
        var items = source.MyTakeLast(10);
        Assert.True(items.SequenceEqual(source));
    }
}
