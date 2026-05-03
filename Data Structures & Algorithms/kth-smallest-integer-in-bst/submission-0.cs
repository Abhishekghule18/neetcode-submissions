/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private void Inorder(TreeNode root, int k, ref List<int> ans){
        if(root == null) return;
        Inorder(root.left,k,ref ans);
        ans.Add(root.val);
        Inorder(root.right,k,ref ans);
        return; 
    }
    public int KthSmallest(TreeNode root, int k) {
        List<int> ans = new(); 
        Inorder(root,k,ref ans);
        return ans[k-1];
    }
}
