namespace LeetCode.Tests;

[TestClass]
public class TwoSumTests
{
    [TestMethod]
    public void TwoSum_1()
    {
        var input = new int[] {2, 7, 11, 15};
        var target = 9;
        var expected = new int[] { 0, 1 };

        var actual = Puzzles.TwoSum(input, target);

        Assert.IsTrue(expected.All(e => actual.Contains(e)));
    }

    [TestMethod]
    public void TwoSum_2()
    {
        var input = new int[] { 3, 2, 4 };
        var target = 6;
        var expected = new int[] { 1, 2 };

        var actual = Puzzles.TwoSum(input, target);

        Assert.IsTrue(expected.All(e => actual.Contains(e)));
    }

    [TestMethod]
    public void TwoSum_3()
    {
        var input = new int[] {3, 3};
        var target = 6;
        var expected = new int[] { 0, 1 };

        var actual = Puzzles.TwoSum(input, target);

        Assert.IsTrue(expected.All(e => actual.Contains(e)));
    }
    
    [TestMethod]
    public void TwoSum_4()
    {
        var input = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
        var target = 11;
        var expected = new int[] { 5, 11 };

        var actual = Puzzles.TwoSum(input, target);

        Assert.IsTrue(expected.All(e => actual.Contains(e)));
    }
}