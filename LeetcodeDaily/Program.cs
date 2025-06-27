using System;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        int current = 1;
        List<int> l = new List<int>();
        for (int i = 0; i < n; i++) {
            l.Add(current);
            if (current * 10 <= n)
            {
                current *= 10;
            }
            else
            {
                while (current%10==9|| current + 1 > n)
                {
                    current /= 10;
                }
                current++;
            }
        }
        return l;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        foreach (int num in s.LexicalOrder(30))
        {
            Console.Write(num + " ");
        }
    }
}