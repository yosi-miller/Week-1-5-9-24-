using System.Text.Json;
using Week_1_5_9_24_.Models;

namespace Week_1_5_9_24_
{
    public class JsonActions
    {
        //O(N)
        public static List<NodeDefenceModelDTO>? ReadJson()
        {
            string jsonString = File.ReadAllText("C:\\Users\\y0504\\codeProject\\IDF - Kodcode\\Data Engineer\\Tests\\Week-1(5-9-24)\\Files\\defenceStrategiesBalanced.json");
            List<NodeDefenceModelDTO>? dataDictionary = JsonSerializer.Deserialize<List<NodeDefenceModelDTO>>(jsonString);
            return dataDictionary;
        }
    }
}
