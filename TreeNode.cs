using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_1_5_9_24_.Models;

namespace Week_1_5_9_24_
{
    public class TreeNode
    {
        public NodeDefenceModel Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        // O(1)
        public TreeNode(NodeDefenceModel _value)
        {
            Value = _value;
            Left = null;
            Right = null;
        }
    }
}
