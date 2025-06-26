using System;
public class Solution
{
    public int LongestSubsequence(string s, int k)
    {
        int count = 0;
        long value = 0;
        int bitPosition = 0;

        for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    count++;
                }
                else
                {
                if (bitPosition < 63)
                {
                    long add = 1L << bitPosition;
                    if (value + add <= k)
                    {
                        value += add;
                        count++;
                    }
                }
            }
                if (bitPosition <63)
                    bitPosition++;
            }
            return count;
        }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.LongestSubsequence("1001010", 5));
    }
}