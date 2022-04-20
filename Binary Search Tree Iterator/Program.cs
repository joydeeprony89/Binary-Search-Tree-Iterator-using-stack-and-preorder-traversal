using System;
using System.Collections.Generic;

namespace Binary_Search_Tree_Iterator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }


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

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }
  public class BSTIterator_UsingInorder
  {
    List<int> ll;
    int currentIndex = 0;
    public BSTIterator_UsingInorder(TreeNode root)
    {
      ll = new List<int>();
      Inorder(root);
    }

    public int Next()
    {
      return ll[currentIndex++];
    }

    public bool HasNext()
    {
      return currentIndex <= ll.Count - 1;
    }

    private void Inorder(TreeNode root)
    {
      if (root == null) return;
      Inorder(root.left);
      ll.Add(root.val);
      Inorder(root.right);
    }
  }

  public class BSTIterator_UsingStack
  {
    Stack<TreeNode> stk = new Stack<TreeNode>();
    public BSTIterator_UsingStack(TreeNode root)
    {
      Add_All(root);
    }

    public int Next()
    {
      var node = stk.Pop();
      Add_All(node.right);
      return node.val;
    }

    public bool HashNext()
    {
      return stk.Count > 0;
    }

    private void Add_All(TreeNode root)
    {
      while(root!= null)
      {
        stk.Push(root);
        root = root.left;
      }
    }
  }
}
