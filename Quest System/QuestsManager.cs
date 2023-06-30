using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuestsManager : MonoBehaviour
{
    [Header("Quests")]
    [Space]
    public List<BasicQuest> basicQuests = new();
    public List<StoryQuest> storyQuests = new();
    public List<JobQuest> jobQuests = new();

    [Header("Quests Pairs")]
    [Space]
    public Dictionary<string, string> basicPairs = new();
    public Dictionary<string, string> storyPairs = new();
    public Dictionary<string, string> jobPairs = new();

    #region Create Quests Pairs

    //----------Create Quests Pairs----------

    public void CreatePairs()
    {
        basicPairs = new Dictionary<string, string>()
        {
            {"b1","boj1" },
            {"b2","boj2" },
            {"b3","boj3" },
            {"b4","boj4" },
            {"b5","boj5" },
            {"b6","boj6" }
        };

        storyPairs = new Dictionary<string, string>()
        {
            {"s1","soj1" },
            {"s2","soj2" },
            {"s3","soj3" },
            {"s4","soj4" },
            {"s5","soj5" },
            {"s6","soj6" }
        };

        jobPairs = new Dictionary<string, string>()
        {
            {"j1","joj1" },
            {"j2","joj2" },
            {"j3","joj3" },
            {"j4","joj4" },
            {"j5","joj5" },
            {"j6","joj6" }
        };
    }

    //---------------------------------------

    #endregion

    //Quests Reward Rules

    //Basic Quests Reward Rules
    // 1-5 lvl (50 - 150 gold) , (20% - 40% exp)
    // 6-10 lvl (200 - 350 gold) , (20% - 30% exp)
    // 11-15 lvl (400 - 650 gold) , (10% - 20% exp)

    //Story Quests Reward Rules
    // 1-5 lvl (50 - 150 gold) , (2 - 6 gems), (20% - 40% exp)
    // 6-10 lvl (200 - 350 gold) , (7 - 11 gems), (20% - 40% exp)
    // 11-15 lvl (400 - 650 gold) , (12 - 16 gems), (20% - 40% exp)

    //Job Quests Reward Rules
    // The Job Quests Give Items And Not Currency
    // Based On The Type Of The Items In The Game That The Player Can Acquire
    // for example: Common Axe, Common Clothes, Legendary Axe, GodLike Boots

    #region Basic Rewards

    //----------Basic Rewards----------
    public int SetBasicRewards()
    {
        // check the player lvl
        // based on the rules
        // return the reward in int

        int[] firstReward = { 50, 100, 150 };
        int[] secondReward = { 200, 250, 300, 350 };
        int[] thirdReward = { 400, 450, 500, 550, 600, 650 };

        int r = 0;

        if (FindObjectOfType<PlayerMovement>().level <= 5)
        {
            int reward = Random.Range(0, firstReward.Length);
            r = firstReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 10 && FindObjectOfType<PlayerMovement>().level >= 6)
        {
            int reward = Random.Range(0, secondReward.Length);
            r = secondReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 15 && FindObjectOfType<PlayerMovement>().level >= 11)
        {
            int reward = Random.Range(0, thirdReward.Length);
            r = thirdReward[reward];
        }

        return r;
    }

    public int SetExpBasicRewards()
    {
        int[] firstExpReward = { 20, 25, 30, 35, 40 };
        int[] secondExpReward = { 20, 25, 30, 35, 40 };
        int[] thirdExpReward = { 20, 25, 30, 35, 40 };

        int r = 0;

        if (FindObjectOfType<PlayerMovement>().level <= 5)
        {
            int reward = Random.Range(0, firstExpReward.Length);
            r = firstExpReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 10 && FindObjectOfType<PlayerMovement>().level >= 6)
        {
            int reward = Random.Range(0, secondExpReward.Length);
            r = secondExpReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 15 && FindObjectOfType<PlayerMovement>().level >= 11)
        {
            int reward = Random.Range(0, thirdExpReward.Length);
            r = thirdExpReward[reward];
        }

        return r;
    }
    //---------------------------------

    #endregion

    #region Story Rewards

    //----------Story Rewards----------
    public int SetGoldStoryRewards()
    {
        // check the player lvl
        // based on the rules
        // return the reward in int

        int[] firstGoldReward = { 50, 100, 150 };
        int[] secondGoldReward = { 200, 250, 300, 350 };
        int[] thirdGoldReward = { 400, 450, 500, 550, 600, 650 };

        int r = 0;

        if (FindObjectOfType<PlayerMovement>().level <= 5)
        {
            int reward = Random.Range(0, firstGoldReward.Length);
            r = firstGoldReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 10 && FindObjectOfType<PlayerMovement>().level >= 6)
        {
            int reward = Random.Range(0, secondGoldReward.Length);
            r = secondGoldReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 15 && FindObjectOfType<PlayerMovement>().level >= 11)
        {
            int reward = Random.Range(0, thirdGoldReward.Length);
            r = thirdGoldReward[reward];
        }

        return r;
    }

    public int SetExpStoryRewards()
    {
        int[] firstExpReward = { 20, 25, 30, 35, 40 };
        int[] secondExpReward = { 20, 25, 30, 35, 40 };
        int[] thirdExpReward = { 20, 25, 30, 35, 40 };

        int r = 0;

        if (FindObjectOfType<PlayerMovement>().level <= 5)
        {
            int reward = Random.Range(0, firstExpReward.Length);
            r = firstExpReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 10 && FindObjectOfType<PlayerMovement>().level >= 6)
        {
            int reward = Random.Range(0, secondExpReward.Length);
            r = secondExpReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 15 && FindObjectOfType<PlayerMovement>().level >= 11)
        {
            int reward = Random.Range(0, thirdExpReward.Length);
            r = thirdExpReward[reward];
        }

        return r;
    }

    public int SetGemStoryRewards()
    {
        int[] firstGemReward = { 2, 4, 6 };
        int[] secondGemReward = { 7, 9, 11 };
        int[] thirdGemReward = { 12, 14, 16 };

        int r = 0;

        if (FindObjectOfType<PlayerMovement>().level <= 5)
        {
            int reward = Random.Range(0, firstGemReward.Length);
            r = firstGemReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 10 && FindObjectOfType<PlayerMovement>().level >= 6)
        {
            int reward = Random.Range(0, secondGemReward.Length);
            r = secondGemReward[reward];
        }
        else if (FindObjectOfType<PlayerMovement>().level <= 15 && FindObjectOfType<PlayerMovement>().level >= 11)
        {
            int reward = Random.Range(0, thirdGemReward.Length);
            r = thirdGemReward[reward];
        }

        return r;
    }
    //---------------------------------

    #endregion

    public void CreateQuests(GameObject g)
    {
        if (g.name == "BasicNPC")
        {
            string[] questKeys = basicPairs.Keys.ToArray();

            string randomKey = questKeys[Random.Range(0, questKeys.Length)];
            string randomValue = basicPairs[randomKey];

            BasicQuest bQuest = new BasicQuest(randomKey, randomValue, SetBasicRewards(), SetExpBasicRewards(), "");

            if (!basicQuests.Contains(bQuest))
            {
                basicQuests.Add(bQuest);
            }

            basicPairs.Remove(randomValue);

            Debug.Log("Basic Quest: " + bQuest);
            Debug.Log("Basic Quests: " + basicQuests.Count);
        }
        else if (g.name == "StoryNPC")
        {
            string[] questKeys = storyPairs.Keys.ToArray();

            string randomKey = questKeys[Random.Range(0, questKeys.Length)];
            string randomValue = storyPairs[randomKey];

            StoryQuest sQuest = new StoryQuest(randomKey, randomValue, SetGoldStoryRewards(), SetGemStoryRewards(), SetExpStoryRewards(), "", "");

            if (!storyQuests.Contains(sQuest))
            {
                storyQuests.Add(sQuest);
            }

            storyPairs.Remove(randomValue);

            Debug.Log("Story Quest: " + sQuest);
            Debug.Log("Story Quests: " + storyQuests.Count);
        }
        else if (g.name == "JobNPC")
        {
            string[] questKeys = jobPairs.Keys.ToArray();

            string randomKey = questKeys[Random.Range(0, questKeys.Length)];
            string randomValue = jobPairs[randomKey];

            JobQuest jQuest = new JobQuest(randomKey, randomValue, "", "");

            if (!jobQuests.Contains(jQuest))
            {
                jobQuests.Add(jQuest);
            }

            jobPairs.Remove(randomValue);

            Debug.Log("Job Quest: " + jQuest);
            Debug.Log("Job Quests: " + jobQuests.Count);
        }
    }

    #region Get Quests

    //----------Get Quests----------

    public BasicQuest GetBasicQuest()
    {
        int randomQuest = Random.Range(0, basicQuests.Count);
        return basicQuests[randomQuest];
    }

    public StoryQuest GetStoryQuest()
    {
        int randomQuest = Random.Range(0, storyQuests.Count);
        return storyQuests[randomQuest];
    }

    public JobQuest GetJobQuest()
    {
        int randomQuest = Random.Range(0, jobQuests.Count);
        return jobQuests[randomQuest];
    }
    //------------------------------

    #endregion
}
