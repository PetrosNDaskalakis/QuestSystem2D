using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    NPCManager npcManager;

    public int npcsLimit;

    // Start is called before the first frame update
    void Start()
    {
        npcManager = FindObjectOfType<NPCManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckNPCsLimit()
    {

    }

    public void OnChangeScene()
    {
        CheckNPCsLimit();
    }
}
