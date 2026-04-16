namespace QuestProgressTracker
{

    public class Objective
    {
        public string Name { get; set; }
        public int RequiredAmount { get; set; }
        public int CurrentAmount { get; private set; }



        public void AddAmount(int amount)
        {
            if(CurrentAmount + amount > RequiredAmount)
            {
                CurrentAmount = RequiredAmount;
            }
            else
            {
                CurrentAmount += amount;
            }
        }
        
    }
}
