using Week_1_5_9_24_.Models;

namespace Week_1_5_9_24_
{
    internal class Program
    {
        //O(1)
        public static int SeverityNumber(string target)
        {
            switch (target)
            {
                case "Web Server":
                    return 10;
                case "Database":
                    return 15;
                case "User Credentials":
                    return 20;
                default:
                    return 5;
            }
        }

        static void Main(string[] args)

        {
            Console.WriteLine("1.1 start to read informtion from defence json");
            List<NodeDefenceModelDTO> nodeDefenceModels = JsonActions.ReadDefenseJson();
            //Thread.Sleep(4000);

            Console.WriteLine("1.3 insert defence to tree");
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
            //Thread.Sleep(4000);

            Console.WriteLine("2.2 print the tree");
            binaryTree.PrintTree();
            //Thread.Sleep(4000);

            Console.WriteLine("3 start to read informtion from defence json");
            List<ThreatsModel> threats = JsonActions.ReadThreatsJson();
            //Thread.Sleep(4000);

            Console.WriteLine("4 calculate the number of severity");
            // O(N)
            foreach (ThreatsModel threat in threats)
            {
                threat.Severity = (threat.Volume + threat.Sophistication) + SeverityNumber(threat.Target);
            }
            //Thread.Sleep(4000);
            
            Console.WriteLine("5 start threat and find defence");
            foreach (ThreatsModel threat in threats)
            {
                Console.WriteLine("Threat: " + threat.ThreatType + " Severity: " + threat.Severity);
                binaryTree.Search(threat.Severity);
            }
        }
    }
}