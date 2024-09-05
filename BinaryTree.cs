using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1_5_9_24_.Models;

namespace Week_1_5_9_24_
{
    public class BinaryTree
    {
        public TreeNode Root;
        public BinaryTree() { Root = null; }

        // O(1)
        public void Insert(NodeDefenceModel value)
        {
            Root = InsertRecursive(Root, value);
        }

        // O(Log N)
        private TreeNode InsertRecursive(TreeNode node, NodeDefenceModel value)
        {
            // this is condition breaking recursive
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }

            if (CalcultorValue(value) < CalcultorValue(node.Value))
                node.Left = InsertRecursive(node.Left, value);
            else // if value >= node.Value
                node.Right = InsertRecursive(node.Right, value);
            return node;
        }

        // O(1)
        // this function calculater wiche node big
        private int CalcultorValue(NodeDefenceModel value)
        {
            return value.GetMaxSeverity() + value.GetMaxSeverity();
        }
    }
}
