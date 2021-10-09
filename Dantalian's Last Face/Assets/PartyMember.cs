using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : MonoBehaviour
{
    int id;
    string name;
    bool isFlipped;
    PartyMember(int id, string name, bool isFlipped)
    {
        this.id = id;
        this.name = name;
        this.isFlipped = isFlipped;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
