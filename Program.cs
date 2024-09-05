using Week_1_5_9_24_.Models;

namespace Week_1_5_9_24_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<NodeDefenceModelDTO> nodeDefenceModels = JsonActions.ReadJson();

            // insert to the BinaryTree
            BinaryTree binaryTree = new BinaryTree();
            if (nodeDefenceModels != null)
            {
                //O(N)
                foreach (NodeDefenceModelDTO newDefence in nodeDefenceModels)
                {
                    NodeDefenceModel nodeDefence = new NodeDefenceModel(newDefence.MinSeverity, newDefence.MaxSeverity, newDefence.Defenses);
                    binaryTree.Insert(nodeDefence);
                }
            }
        }
    }
}