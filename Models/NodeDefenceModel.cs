using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_5_9_24_.Models
{
    public class NodeDefenceModel
    {
        private int MinSeverity { get; set; }
        private int MaxSeverity { get; set; }
        private List<string> Defenses { get; set; }

        // O(1)
        public NodeDefenceModel(int _min, int _max, List<string> _Defence) 
        {
            MinSeverity = _min;
            MaxSeverity = _max;
            Defenses = _Defence;
        }

        // O(1)
        public int GetMinSeverity()
        {
            return MinSeverity;
        }

        // O(1)
        public int GetMaxSeverity()
        {
            return MaxSeverity;
        }

        // O(1)
        public List<string> GetDefenses()
        {
            return Defenses;
        }
    }
}
