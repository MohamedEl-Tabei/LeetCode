public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        PriorityQueue<long, long> pq = new PriorityQueue<long, long>();
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            pq.Enqueue(nums[i], nums[i]);
        }
        while (pq.Count > 1)
        {
            long x = pq.Dequeue();
            long y = pq.Dequeue();
            if (y >= k && x >= k) break;
            long z = (Math.Min(x, y) * 2) + Math.Max(x, y);
            if (z < k || pq.Count == 1) pq.Enqueue(z, z);
            count++;
        }
        return count;
    }
}