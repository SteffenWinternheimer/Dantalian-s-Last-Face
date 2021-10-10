using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : MonoBehaviour
{
    int id;
    public string name;
    bool isFlipped;
    public List<string> states;
    public Animator animator;
    public Animation animation;

    public bool isFlippedState()
    {
        isFlipped = gameObject.GetComponent<SpriteRenderer>().flipX;
        return isFlipped;
    }

    public void PlayAnimation()
    {
        
    }
}
