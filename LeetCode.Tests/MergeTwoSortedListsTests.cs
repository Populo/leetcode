namespace LeetCode.Tests;

[TestClass]
public class MergeTwoSortedListsTests
{
    [TestMethod]
    public void MergeTwoSortedLists_1()
    {
        var list1 = new Puzzles.ListNode(1, new Puzzles.ListNode(2, new Puzzles.ListNode(4)));
        var list2 =
            new Puzzles.ListNode(1, new Puzzles.ListNode(3, new Puzzles.ListNode(4)));
        int[] expected = [1, 1, 2, 3, 4, 4];

        var result = Puzzles.MergeTwoSortedLists(list1, list2);

        Assert.IsTrue(expected.SequenceEqual(result.ToArray()));
    }

    [TestMethod]
    public void MergeTwoSortedLists_2()
    {
        int[] expected = [];

        var result = Puzzles.MergeTwoSortedLists(null, null);

        Assert.IsNull(result);
    }

    [TestMethod]
    public void MergeTwoSortedLists_3()
    {
        var list2 = new Puzzles.ListNode();
        int[] expected = [0];

        var result = Puzzles.MergeTwoSortedLists(null, list2);

        Assert.IsTrue(expected.SequenceEqual(result.ToArray()));
    }
}