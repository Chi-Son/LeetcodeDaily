using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
public class Solution
{
    public int NumSubseq(int[] nums, int target)
    {
        int MOD = 1_000_000_007;
        int left = 0;
        int[] pow2 = new int[nums.Length];
        pow2[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            pow2[i] = (pow2[i - 1] * 2) % MOD;
        }
        int right = nums.Length - 1;
        long cnt = 0;
        Array.Sort(nums);
        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                cnt = (cnt + pow2[right - left]) % MOD;
                left++;
            }
            else
            {
                right--;
            }
        }
        return (int)cnt;
    }
}
class Program
{
    static void Main(string[] args)
    {

    }
}