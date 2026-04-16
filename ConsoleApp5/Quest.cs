using QuestProgressTracker;
namespace QuestProgressTracker
{
    public class Quest
    {
        private string v;
        List<Objective> AcceptedQuests = new List<Objective>();

        public Quest(string v)
        {
            this.v = v;
        }

        public bool IsCompleted { get; set; }

        public void AddObjective(string name, int required)
        {
            Objective obj = new Objective();
            obj.Name = name;
            obj.RequiredAmount = required;
            AcceptedQuests.Add(obj);
        }

        public Objective GetObjective(Objective v)
        {
           if(AcceptedQuests.Contains(v))
            {
                return v;
            }
            throw new ArgumentException("No quest with that name");
        }

        public void ProgressObjective(string v1, int v2)
        {
            if (AcceptedQuests.Count > 0)
            {
                foreach (Objective obj in AcceptedQuests)
                {
                    if (obj.Name == v1)
                    {
                        obj.AddAmount(v2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No quest with that name");
                    }
                }
            }
            else
            {
                IsCompleted = true;
                Console.WriteLine("Quest complete");
            }
        }
    }
}
