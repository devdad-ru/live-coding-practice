using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class IsIsomorphicTests
{
    [Fact]
    public void IsIsomorphic_ShouldReturnCorrectResults_FromSourceTests()
    {
        Assert.True(LiveCodingPractice.IsIsomorphic("egg", "add"));
        Assert.False(LiveCodingPractice.IsIsomorphic("foo", "bar"));
        Assert.True(LiveCodingPractice.IsIsomorphic("paper", "title"));
        Assert.False(LiveCodingPractice.IsIsomorphic("ab", "aa"));
        Assert.False(LiveCodingPractice.IsIsomorphic("abc", "ab"));
        Assert.True(LiveCodingPractice.IsIsomorphic("", ""));
        Assert.True(LiveCodingPractice.IsIsomorphic("a", "a"));
        Assert.True(LiveCodingPractice.IsIsomorphic("a", "b"));
        Assert.False(LiveCodingPractice.IsIsomorphic("aa", "ab"));
        Assert.True(LiveCodingPractice.IsIsomorphic("abba", "cddc"));
        Assert.False(LiveCodingPractice.IsIsomorphic("abcabc", "xyzxzy"));
    }

    [Fact]
    public void IsIsomorphic_WithRepeatedPattern_WorksCorrectly()
    {
        Assert.True(LiveCodingPractice.IsIsomorphic("abab", "cdcd"));
    }
}
