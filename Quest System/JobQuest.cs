[System.Serializable]
public class JobQuest
{
    public string name;
    public string objective;
    public string reward;
    public string itemToObtain;
    public bool completed;

    public JobQuest(string name, string objective, string reward, string itemToObtain)
    {
        this.name = name;
        this.objective = objective;
        this.reward = reward;
        this.itemToObtain = itemToObtain;
        completed = false;
    }
}