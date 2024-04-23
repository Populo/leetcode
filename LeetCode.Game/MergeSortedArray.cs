namespace LeetCode.Game;

public partial class Puzzles
{
    public static void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
    {
        int[] copy = new int[m];
        
        int i = 0, m1 = 0, n1 = 0;
        
        while (i < m)
        {
            copy[i] = nums1[i];
            ++i;
        }
        i = 0;
        
        while (i < nums1.Length)
        {
            if (m1 == m)
            {
                nums1[i] = nums2[n1];
                ++n1;
                ++i;
                continue;
            }
            if (n1 == n)
            {
                nums1[i] = copy[m1];
                ++m1;
                ++i;
                continue;
            }
            
            if (copy[m1] > nums2[n1])
            {
                nums1[i] = nums2[n1];
                ++n1;
            }
            else
            {
                nums1[i] = copy[m1];
                ++m1;
            }
            ++i;
        }
    }
}