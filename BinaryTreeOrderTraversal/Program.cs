/*
 * Binary Tree Level Order Traversal
 * =================================
 * Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).

For example:
======================================
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its level order traversal as:
[
  [3],
  [9,20],
  [15,7]
]
 * 
 * 
 * 
 */

using Nodes;
using System;
using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversal
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
            IList<IList<int>> result = p.LevelOrder(root);

            

        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
           
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> currentLevel = new List<int>();
                int queueSize = queue.Count;
                for (int i = 0; i < queueSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);

                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }

                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }

                    
                }
                result.Add(currentLevel);
            }

            return result;
        }
    }
}
