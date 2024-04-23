namespace LeetCode.Tests;


[TestClass]
public class SortListNodeTests
{
    [TestMethod]
    public void SortListNode_EqualsOverride_1()
    {
        var list1 = new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4))));
        var list2 =
            new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4))));

        var equal = list1.Equals(list2);
        
        Assert.AreEqual(true, equal);
    }
    
    [TestMethod]
    public void SortListNode_EqualsOverride_2()
    {
        var list1 = new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4))));
        var list2 =
            new Puzzles.ListNode(2, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4, new Puzzles.ListNode(7)))));

        var equal = list1.Equals(list2);
        
        Assert.AreEqual(false, equal);
    }
    
    [TestMethod]
    public void SortListNode_EqualsOverride_3()
    {
        var list1 = new Puzzles.ListNode(4, new Puzzles.ListNode(3, new Puzzles.ListNode(2, new Puzzles.ListNode(1))));
        var list2 =
            new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4))));

        var equal = list1.Equals(list2);
        
        Assert.AreEqual(false, equal);
    }
    
    [TestMethod]
    public void SortListNode_1()
    {
        var input = new Puzzles.ListNode(4, new Puzzles.ListNode(2, new Puzzles.ListNode(1, new Puzzles.ListNode(3))));
        var expected =
            new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(3, new Puzzles.ListNode(4))));

        var actual = Puzzles.SortListNode(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void SortListNode_2()
    {
        var input = new Puzzles.ListNode(-1, new Puzzles.ListNode(5, new Puzzles.ListNode(3, new Puzzles.ListNode(4, new Puzzles.ListNode(0)))));
        var expected =
            new Puzzles.ListNode(-1, new Puzzles.ListNode(0, new Puzzles.ListNode(3, new Puzzles.ListNode(4, new Puzzles.ListNode(5)))));

        var actual = Puzzles.SortListNode(input);
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void SortListNode_3()
    {
        Puzzles.ListNode input = null;
        Puzzles.ListNode expected = null;

        var actual = Puzzles.SortListNode(input);
        
        Assert.AreEqual(expected, actual);
    }
}