public class Solution
{
    public long ColoredCells(int n)
    {
        long result = 1;
        for (int i = 1; i < n; i++)
        {
            result = result + (4 * i);
        }
        return result;
    }
}