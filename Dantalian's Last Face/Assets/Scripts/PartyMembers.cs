using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMembers : MonoBehaviour
{

    public GameObject[] partyMembers;
    public PartySpawner partySpawner;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn each party member at a given position
        for(int i = 0; i < partyMembers.Length; i++)
        {
            Instantiate(partyMembers[i], partySpawner.spawnPositions[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
