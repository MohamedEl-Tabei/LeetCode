public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        TreeNode ptr = new TreeNode();
        List < int > result=new List < int > ();
        ptr = root;
        void sortTree(TreeNode p)
        {
            if (p == null) return;
            result.Add(p.val);
            sortTree(p.left);
            sortTree(p.right);
        }
        sortTree(ptr);
        result.Sort();
        return result[k - 1];
    }
}