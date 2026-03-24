using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class MoveZeroesTests
{
    [Fact]
    public void MoveZeroes_ReturnsValidResult_FromSourceTests()
    {
        Assert.True(new[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }.SequenceEqual(LiveCodingPractice.MoveZeroes([
            1, 2, 0, 1, 0, 1, 0, 3, 0, 1
        ])));
        Assert.True(new[] { 1, 2, 3, 0 }.SequenceEqual(LiveCodingPractice.MoveZeroes([1, 2, 3, 0])));
        Assert.True(new[] { 1, 2, 3, 0 }.SequenceEqual(LiveCodingPractice.MoveZeroes([0, 1, 2, 3])));
    }

    [Fact]
    public void MoveZeroes_WithAllZeroes_ReturnsSameLengthZeroArray()
    {
        Assert.True(new[] { 0, 0, 0 }.SequenceEqual(LiveCodingPractice.MoveZeroes([0, 0, 0])));
    }

    [Fact]
    public void MoveZeroes_WithNoZeroes_ReturnsSameSequence()
    {
        Assert.True(new[] { 4, 5, 6 }.SequenceEqual(LiveCodingPractice.MoveZeroes([4, 5, 6])));
    }
}
