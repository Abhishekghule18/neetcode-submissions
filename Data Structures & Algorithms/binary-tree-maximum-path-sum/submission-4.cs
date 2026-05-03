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

    private int Dfs(TreeNode node, ref int maxSum){

        if(node == null) return 0;
        
        int leftSum = Math.Max(0, Dfs(node.left, ref maxSum));
        int rightSum = Math.Max(0, Dfs(node.right, ref maxSum));
        int currMax = node.val + leftSum + rightSum;
        maxSum = Math.Max(currMax,maxSum);
        return node.val + Math.Max(leftSum, rightSum);

    }

    public int MaxPathSum(TreeNode root) {

        int maxSum = int.MinValue;
        Dfs(root, ref maxSum);

        return maxSum;

    }
}