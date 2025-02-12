public class Solution {
    public int MaximumSum(int[] nums) {
        Dictionary < int, int > d=new Dictionary<int, int>();
        int maxSum = 0;
        Array.Sort(nums);
        for (int i = nums.Length - 1; i > -1; i--) {

            int key = 0;
            int num = nums[i];
            while (num > 0) {
                int v = num % 10;
                num = (num - v) / 10;
                key = key + v;
            }
            if (d.ContainsKey(key)) {
                int sum = d[key] + nums[i];
                if (sum > maxSum) maxSum = sum;
            }
            else {
                d.Add(key, nums[i]);
            }
        }
        return maxSum > 0 ? maxSum : -1;
    }
}