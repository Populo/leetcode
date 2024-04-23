namespace LeetCode.Game;

public partial class Puzzles
{
    public static int[] TwoSum(int[] nums, int target)
    { 
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; ++i)
        {
            var difference = target - nums[i];
            if (map.ContainsKey(nums[i])) return [map[nums[i]], i];
            else map[difference] = i;
        }
        
        return [];
    }
}