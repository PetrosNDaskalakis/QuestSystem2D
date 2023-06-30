using UnityEngine;
using System.Collections.Generic;

public class NPCManager : MonoBehaviour
{
    [Header("NPCs Prefabs")]
    [Space]
    public List<GameObject> npcs = new List<GameObject>();

    [Header("NPCs Lists")]
    [Space]
    public List<GameObject> basicNpcs = new List<GameObject>();
    public List<GameObject> storyNpcs = new List<GameObject>();
    public List<GameObject> jobNpcs = new List<GameObject>();

    [Header("Positions")]
    [Space]
    public List<Transform> npcsPlaces = new();

    [Header("References")]
    [Space]
    public QuestsManager questManager;
    public GameManager gm;

    public bool spawnedMain = false;

    // Rules Of NPC Generator
    //=======================
    // If it's the start of the game spawn 1 Story NPC
    //-----------------------
    // If there are 3 Spawn Points, Spawn 1 Story NPC (if storyQuest is completed),
    // 1 Basic NPC and 1 Job NPC.
    //-----------------------
    // If there are 6 Spawn Points, Spawn 1 Story NPC (if storyQuest is completed),
    // 3 Basic NPC and 2 Job NPC.
    //-----------------------
    // If storyQuest isnt completed then replace with Basic NPC
    //=======================

    public void GenerateNPCs()
    {
        int repeatTimes = npcsPlaces.Count;

        for (int i = 0; i < repeatTimes; i++)
        {
            if (spawnedMain == false)
            {
                Transform t = npcsPlaces[Random.Range(0, npcsPlaces.Count)];
                GameObject g = npcs[0];

                GameObject npc = Instantiate(g, t);

                npc.AddComponent<StoryNPC>();
                questManager.CreateQuests(g);
                npc.GetComponent<StoryNPC>().storyQuest = questManager.GetStoryQuest();
                questManager.storyQuests.Remove(questManager.GetStoryQuest());
                storyNpcs.Add(npc);

                npcsPlaces.Remove(t);

                spawnedMain = true;
            }
            else
            {
                Transform t = npcsPlaces[Random.Range(0, npcsPlaces.Count)];
                GameObject g = npcs[Random.Range(1, npcs.Count)];

                GameObject npc = Instantiate(g, t);

                npcsPlaces.Remove(t);

                if (g.name == "BasicNPC")
                {
                    npc.AddComponent<BasicNPC>();
                    questManager.CreateQuests(g);
                    npc.GetComponent<BasicNPC>().basicQuest = questManager.GetBasicQuest();
                    questManager.basicQuests.Remove(questManager.GetBasicQuest());
                    basicNpcs.Add(npc);
                }
                else if (g.name == "JobNPC")
                {
                    npc.AddComponent<JobNPC>();
                    questManager.CreateQuests(g);
                    npc.GetComponent<JobNPC>().jobQuest = questManager.GetJobQuest();
                    questManager.jobQuests.Remove(questManager.GetJobQuest());
                    jobNpcs.Add(npc);
                }
            }
        }
    }
}