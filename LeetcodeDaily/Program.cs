using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
public class Solution
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        int[]copy= (int[])nums.Clone();
        Array.Sort(copy);
        Array.Reverse(copy);
        int n = 0;
        Dictionary <int,int>store = new Dictionary<int,int>();
        for (int i = 0; i < k; i++) {
            if (store.ContainsKey(copy[n])) {
                store[copy[n]]++;
            }
            else
            {
                store[copy[n]] = 1;
            }
            n++;
        }
        List<int>result = new List<int>();
        foreach (int num in nums)
        {
            if (store.ContainsKey(num) && store[num] > 0)
            {
                result.Add(num);
                store[num] --;
            }
        }
        return result.ToArray();
    }
}
class Program
{
    static void Main(string[] args)
    {

    }
}