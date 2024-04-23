namespace LeetCode.Tests;

[TestClass]
public class MergeSortedArrayTests
{
    [TestMethod]
    public void MergeSortedArray_1()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int m = 3;
        int[] nums2 = [2, 5, 6];
        int n = 3;

        int[] expected = [1, 2, 2, 3, 5, 6];

        Puzzles.MergeSortedArray(nums1, m, nums2, n);
        
        Assert.IsTrue(expected.SequenceEqual(nums1));
    }

    [TestMethod]
    public void MergeSortedArray_2()
    {
        int[] nums1 = [1];
        int m = 1;
        int[] nums2 = [];
        int n = 0;

        int[] expected = [1];

        Puzzles.MergeSortedArray(nums1, m, nums2, n);

        Assert.IsTrue(expected.SequenceEqual(nums1));
    }

    [TestMethod]
    public void MergeSortedArray_3()
    {
        int[] nums1 = [0];
        int m = 0;
        int[] nums2 = [1];
        int n = 1;

        int[] expected = [1];

        Puzzles.MergeSortedArray(nums1, m, nums2, n);
        
        Assert.IsTrue(expected.SequenceEqual(nums1));
    }
}