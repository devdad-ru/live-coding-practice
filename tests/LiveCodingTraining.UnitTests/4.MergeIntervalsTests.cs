using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class MergeIntervalsTests
{
    [Fact]
    public void MergeIntervals_ReturnsValidResult_FromSourceTests()
    {
        var result1 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 3],
            [2, 6],
            [8, 10],
            [15, 18]
        });
        Assert.Equal(new int[][]
        {
            [1, 6],
            [8, 10],
            [15, 18]
        }, result1);

        var result2 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 4],
            [4, 5]
        });
        Assert.Equal(new int[][]
        {
            [1, 5]
        }, result2);

        var result3 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 4],
            [5, 6]
        });
        Assert.Equal(new int[][]
        {
            [1, 4],
            [5, 6]
        }, result3);

        var result4 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 4],
            [2, 3]
        });
        Assert.Equal(new int[][]
        {
            [1, 4]
        }, result4);

        var result5 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [2, 6],
            [1, 3],
            [15, 18],
            [8, 10]
        });
        Assert.Equal(new int[][]
        {
            [1, 6],
            [8, 10],
            [15, 18]
        }, result5);

        var result6 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 5]
        });
        Assert.Equal(new int[][]
        {
            [1, 5]
        }, result6);

        var result7 = LiveCodingPractice.MergeIntervals(new int[][] { });
        Assert.Equal(new int[][] { }, result7);

        var result8 = LiveCodingPractice.MergeIntervals(new int[][]
        {
            [1, 10],
            [2, 5],
            [3, 7],
            [6, 8],
            [9, 12]
        });
        Assert.Equal(new int[][]
        {
            [1, 12]
        }, result8);
    }

    [Fact]
    public void MergeIntervals_WithNegativeBounds_WorksCorrectly()
    {
        int[][] result = LiveCodingPractice.MergeIntervals([[-10, -5], [-7, -1], [0, 2]]);
        Assert.Equal([[-10, -1], [0, 2]], result);
    }
}
