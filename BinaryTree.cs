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

        // O(1)
        public void PrintTree()
        {
            printPreorder(Root);
        }

        // O(Log N)
        public void printPreorder(TreeNode node)
        {
            if (node == null)
                return;

            // Deal with the node
            Console.WriteLine("[" + node.Value.GetMinSeverity().ToString() + "-" + node.Value.GetMinSeverity().ToString() + "] Defenses: " + node.Value.GetDefenses()[0] + ", " + node.Value.GetDefenses()[1]);

            // Recur on left subtree
            printPreorder(node.Left);

            // Recur on right subtree
            printPreorder(node.Right);
        }

        // O(Log N)
        public void Search(int )
    }
}
