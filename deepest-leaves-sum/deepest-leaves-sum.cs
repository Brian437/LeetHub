/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int DeepestLeavesSum(TreeNode root) {
        List<int> levelSum=new List<int>();
        DeepestLeavesSumRecursion(root,0,levelSum);
        foreach(int sum in levelSum)
        {
            Console.WriteLine(sum);
        }
        return levelSum[levelSum.Count-1];
    }
    public void DeepestLeavesSumRecursion(TreeNode node, int level,List<int> levelSum)
    {
        if(levelSum.Count<=level)
        {
            levelSum.Add(0);
        }
        levelSum[level]+=node.val;
        if(node.left!=null)
        {
            DeepestLeavesSumRecursion(node.left,level+1,levelSum);
        }
        if(node.right!=null)
        {
            DeepestLeavesSumRecursion(node.right,level+1,levelSum);
        }
    }
}