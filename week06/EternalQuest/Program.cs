// Exceeding Requirements:
// 1. Added a Leveling System: The user gains levels based on their total score (1 Level per 1000 points).
// 2. Level display: Included the level progression directly in the user status prompt.

namespace EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}