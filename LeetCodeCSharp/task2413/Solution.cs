namespace LeetCodeCSharp.task2413;

public class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        if (n % 2 == 0)
        {
            return n;
        }
        return n * 2;
    }
}