using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class FindEvenIndexTests
{
    [Fact]
    public void FindEvenIndex_ReturnsValidResult_FromSourceTests()
    {
        Assert.Equal(3, LiveCodingPractice.FindEvenIndex([1, 2, 3, 4, 3, 2, 1]));
        Assert.Equal(1, LiveCodingPractice.FindEvenIndex([1, 100, 50, -51, 1, 1]));
        Assert.Equal(-1, LiveCodingPractice.FindEvenIndex([1, 2, 3, 4, 5, 6]));
        Assert.Equal(3, LiveCodingPractice.FindEvenIndex([20, 10, 30, 10, 10, 15, 35]));
        Assert.Equal(-1, LiveCodingPractice.FindEvenIndex([]));
    }

    [Fact]
    public void FindEvenIndex_WithSingleElement_ReturnsZero()
    {
        Assert.Equal(0, LiveCodingPractice.FindEvenIndex([42]));
    }
}
