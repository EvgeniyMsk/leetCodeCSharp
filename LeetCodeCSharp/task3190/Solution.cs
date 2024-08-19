namespace LeetCodeCSharp;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result += Math.Min(nums[i] % 3, 3 - nums[i] % 3);
        }
        return result;
    }
}