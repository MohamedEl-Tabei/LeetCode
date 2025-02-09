public class Solution {
    public long CountBadPairs(int[] nums) {
        Dictionary < int, List < int >> d=new Dictionary < int, List < int >> ();
        long count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
           int key = nums[i] - i;
            if (d.ContainsKey(key)) {
                d[key].Add(i);
            }
            else {
                List < int > l= new List < int > ();
                l.Add(i);
                d.Add(key, l);
            }
        }
        foreach(int k in d.Keys)
        {
            for (int i = 0; i < d[k].Count; i++) {
                count = count + (nums.Length - 1 - d[k][i]);
                count = count - (d[k].Count - i - 1);
            }
        }
        return count;
    }
}