using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {   
        Dictionary<int,int> map = new Dictionary<int,int>();
         
        for (int i = 0; i < nums.Length; i++)
        {
            int aim = target - nums[i];
            if (map.ContainsKey(nums[i]) && map[nums[i]]>0)
            {
                return new int[2] { map[aim],i};
            }
            else
            {
                map[aim] = i;
            }
        }
        return new int[0];
    }
}
class Program
{
    static void Main(string[] args)
    {

    }
}