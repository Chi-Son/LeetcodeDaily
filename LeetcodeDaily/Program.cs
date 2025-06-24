using System;
public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {  
                    if (nums[j] == key && Math.Abs(i - j) <= k)
                    {
                        result.Add(i);
                        break;
                    }
            }
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Solution s = new Solution();
        var result = s.FindKDistantIndices([3, 4, 9, 1, 3, 9, 5], 9, 1);
        Console.WriteLine(string.Join(", ", result));
    }
}