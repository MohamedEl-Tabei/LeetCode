public class Solution
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var result = new SortedDictionary<int, int>();
        int[][] arr;
        int count = 0;
        for (int i = 0; i < nums1.Length; i++)
            if (!result.TryAdd(nums1[i][0], nums1[i][1])) result[nums1[i][0]] = result[nums1[i][0]] + nums1[i][1];

        for (int i = 0; i < nums2.Length; i++)
            if (!result.TryAdd(nums2[i][0], nums2[i][1])) result[nums2[i][0]] = result[nums2[i][0]] + nums2[i][1];

        arr = new int[result.Count][];
        foreach (var kv in result)
        {
            arr[count] = new int[2];
            arr[count][0] = kv.Key;
            arr[count][1] = kv.Value;
            count++;
        }
        return arr;
    }
}