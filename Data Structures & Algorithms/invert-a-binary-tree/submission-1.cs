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
    public TreeNode InvertTree(TreeNode root) {
        
        if(root == null) return root;

        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while(q.Count() != 0){
            TreeNode current = q.Dequeue();
            if(current.left != null) q.Enqueue(current.left);
            if(current.right != null) q.Enqueue(current.right);

            TreeNode temp = current.left ?? null;
            current.left = current.right;
            current.right = temp;
        }

        return root;
        
    }
}
