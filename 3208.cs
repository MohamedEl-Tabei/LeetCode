public class Solution
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        int count = 0;
        int lastItem = colors[0];
        int size = 1;
        var q = new Queue<int>();

        for (int i = 0; i < colors.Length; i++)
        {
            q.Enqueue(i);
        }
        for (int i = 1; q.Count > 0; i = (i + 1) % colors.Length)
        {
            if (lastItem == colors[i])
            {
                while (size > 0)
                {
                    if (q.Count > 0) { q.Dequeue(); size--; }
                    else size = 0;
                }
            }
            lastItem = colors[i];
            size++;
            if (size == k) { count++; size--; q.Dequeue(); }
        }

        return count;
    }
}