using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : MonoBehaviour
{
    int id;
    public string name;
    bool isFlipped;

    public bool isFlippedState()
    {
        isFlipped = gameObject.GetComponent<SpriteRenderer>().flipX;
        return isFlipped;
    }
}
