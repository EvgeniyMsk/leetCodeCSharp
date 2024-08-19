namespace LeetCodeCSharp.task2894;

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int nonDiv = 0;
        int div = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % m != 0)
                nonDiv += i;
            else
                div += i;
        }
        return nonDiv - div;
    }
}