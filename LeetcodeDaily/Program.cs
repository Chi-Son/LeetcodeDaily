using System;

public class Solution
{
    public long ChangeBase(long n, long k)
    {
        string digit = "";
        while (n > 0)
        {
            long ans = n % k;
            digit = ans.ToString() + digit;
            n = n / k;
        }
        return long.Parse(digit);
    }

    public bool IsPalindrome(long n)
    {
        string check = n.ToString();
        char[] chars = check.ToCharArray();
        Array.Reverse(chars);
        string reverse = new string(chars);
        return check == reverse;
    }
    public long KMirror(long k, long n)
    {
        long count = 0;
        long sum = 0;
        long numLength = 1;
        while (true)
        {
            long x = (long)Math.Ceiling((double)numLength / 2);
            long start = (long)Math.Pow(10, x - 1);
            long end = (long)Math.Pow(10, x);
            for (long i = start; i < end; i++)
            {
                string full;
                string temp = i.ToString();
                if (numLength % 2 == 0)
                {
                    full = temp + new string(temp.Reverse().ToArray());
                }
                else
                {
                    string reverse = new string(temp.Reverse().ToArray());
                    full = temp + reverse.Substring(1);
                }
                long num = long.Parse(full);
                if (IsPalindrome(ChangeBase(num, k)))
                {
                    sum += num;
                    count++;
                    if (count == n)
                        return sum;
                }
            }
            numLength++;
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        long result = solution.KMirror(2, 5);
        Console.WriteLine(result);
    }
}