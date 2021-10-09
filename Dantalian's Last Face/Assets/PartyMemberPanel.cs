using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyMemberPanel : MonoBehaviour
{
    public Text nameText;
    string name;
    bool isFlipped;
    public GameObject partyMember;
    public void AssignInformationToPanel(GameObject partyMember)
    {
        this.partyMember = partyMember;
        PartyMember memberScript = partyMember.GetComponent<PartyMember>();
        name = memberScript.name;
        isFlipped = memberScript.isFlippedState();
        nameText.text = name;
    }

    public void FlipCharacter()
    {
        
        partyMember.GetComponent<SpriteRenderer>().flipX = !isFlipped;
        isFlipped = !isFlipped;
    }

    public void RemovePartyMember()
    {
        Destroy(partyMember);
        Destroy(gameObject);
    }
}
