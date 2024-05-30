using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
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
    public class ValidBST
    {
        public bool IsValidBST(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            Queue<TreeNode> qleft = new Queue<TreeNode>();
            Queue<TreeNode> qright = new Queue<TreeNode>();

            int rootval = root.val;
            bool valid = true;

            if (root.left != null)
            {
                if (rootval <= root.left.val)
                    return false;
                qleft.Enqueue(root.left);
            }
            if (root.right != null)
            {
                if (rootval >= root.right.val)
                    return false;
                qright.Enqueue(root.right);
            }

            //check each side of the tree separately
            valid = traversetree(qleft, true, rootval) && traversetree(qright, false, rootval);

            return valid;

        }

        private bool traversetree(Queue<TreeNode> q, bool isleftside, int rootval)
        {
            bool valid = true;
            while (q.Count() > 0)
            {
                if (q.Peek().left != null)
                {
                    if (q.Peek().left.val >= q.Peek().val)
                        valid = false;
                    q.Enqueue(q.Peek().left);
                    if (q.Peek().val >= rootval && isleftside)
                        valid = false;
                }
                if (q.Peek().right != null)
                {
                    if (q.Peek().right.val <= q.Peek().val)
                        valid = false;
                    q.Enqueue(q.Peek().right);
                    if (q.Peek().val <= rootval && !isleftside)
                        valid = false;
                }

                q.Dequeue();

            }

            return valid;
        }
    }
