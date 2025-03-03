public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        var qG = new Queue<int>();
        var qS = new Queue<int>();
        int numOfPivot = 0;
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == pivot) numOfPivot++;
            else if (nums[i] < pivot) qS.Enqueue(nums[i]);
            else qG.Enqueue(nums[i]);
        }
        while (numOfPivot > 0)
        {
            qS.Enqueue(pivot);
            numOfPivot--;
        }
        while (qG.Count > 0) qS.Enqueue(qG.Dequeue());
        return qS.ToArray();
    }
}