using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSetter : MonoBehaviour
{
    public List<Transform> npcsPlaces = new();

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<NPCManager>().npcsPlaces = npcsPlaces;
        FindObjectOfType<QuestsManager>().CreatePairs();
        FindObjectOfType<NPCManager>().GenerateNPCs();
    }

    // Update is called once per frame
    void Update()
    {

    }
}