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
    private void Dfs(TreeNode node, int[] arr){
        if(node == null) return;

        Dfs(node.left,arr);
        if(arr[0] == 0) return;

        arr[0]--;
        if(arr[0] == 0){
            arr[1] = node.val;
            return;
        }

        Dfs(node.right,arr);  
    }
    public int KthSmallest(TreeNode root, int k) {
        int[] arr = new int[2];
        arr[0] = k;
        Dfs(root, arr);
        return arr[1];
        
    }
}
