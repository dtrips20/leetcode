/*
Maximum Depth of Binary Tree
====================================================
Given a binary tree, find its maximum depth.
The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

Note: A leaf is a node with no children.

Example:
Given binary tree [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
return its depth = 3.

 
 */
using Nodes;
using System;

namespace MaximumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            Program p = new Program();
            Console.WriteLine(p.MaxDepth(root));
        }
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);
            int result = Math.Max(leftHeight, rightHeight) + 1;
            return result;
        }
    }
}