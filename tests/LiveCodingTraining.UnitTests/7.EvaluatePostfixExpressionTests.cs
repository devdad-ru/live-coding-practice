using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class EvaluatePostfixExpressionTests
{
    [Theory]
    [InlineData("2 1 + 3 *", 9)]
    [InlineData("4 13 5 / +", 6)]
    [InlineData("10 6 9 3 + -11 * / * 17 + 5 +", 22)]
    [InlineData("5 1 2 + 4 * + 3 -", 14)]
    public void EvaluatePostfixExpression_WithValidExpression_ReturnsExpectedResult(string expression, int expected)
    {
        int result = LiveCodingPractice.EvaluatePostfixExpression(expression);
        Assert.Equal(expected, result);
    }
}
