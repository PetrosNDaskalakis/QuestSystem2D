[System.Serializable]
public class BasicQuest
{
    public string name;
    public string objective;
    public int goldReward;
    public int expReward;
    public string targetToKill;
    public bool completed;

    public BasicQuest(string name, string objective, int goldReward, int expReward, string targetToKill)
    {
        this.name = name;
        this.objective = objective;
        this.goldReward = goldReward;
        this.expReward = expReward;
        this.targetToKill = targetToKill;
        completed = false;
    }
}
