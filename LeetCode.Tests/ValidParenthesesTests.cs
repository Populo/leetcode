namespace LeetCode.Tests;

[TestClass]
public class ValidParenthesesTests {
    
    [TestMethod]
    public void ValidParentheses_1()
    {
        var input = "()";
        var expected = true;
        var result = Puzzles.ValidParentheses(input);
        
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ValidParentheses_2()
    {
        var input = "()[]{}";
        var expected = true;
        var result = Puzzles.ValidParentheses(input);
        
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ValidParentheses_3()
    {
        var input = "(]";
        var expected = false;
        var result = Puzzles.ValidParentheses(input);
        
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]
    public void ValidParentheses_4()
    {
        var input = "([)]";
        var expected = false;
        var result = Puzzles.ValidParentheses(input);
        
        Assert.AreEqual(expected, result);
    }
}