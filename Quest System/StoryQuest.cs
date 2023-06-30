using Unity.VisualScripting;

[System.Serializable]
public class StoryQuest
{
    public string name;
    public string objective;
    public int goldReward;
    public int gemsReward;
    public int expReward;
    public bool completed;
    public string targetToKill;
    public string itemToObtain;

    public StoryQuest(string name, string objective, int goldReward, int gemsReward,int expReward, string targetToKill, string itemToObtain)
    {
        this.name = name;
        this.objective = objective;
        this.goldReward = goldReward;
        this.gemsReward = gemsReward;
        this.expReward = expReward;
        this.completed = false;
        this.targetToKill = targetToKill;
        this.itemToObtain = itemToObtain;
    }
}