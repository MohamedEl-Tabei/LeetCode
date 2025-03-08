public class Solution
{
    public int MinimumRecolors(string blocks, int k)
    {
        int min = -1;
        int count;
        for (int i = 0; i < blocks.Length; i++)
        {
            count = 0;
            if (i + k > blocks.Length) break;
            for (int j = i; j < i + k; j++)
            {
                if (blocks[j] == 'W') count++;
            }
            if (min == -1) min = count;
            if (count < min) min = count;
        }

        return min;
    }
}