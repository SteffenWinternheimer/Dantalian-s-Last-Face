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

    public Dropdown dropdownOptions;
    public Text selectionText;

    public void AssignInformationToPanel(GameObject partyMember)
    {
        this.partyMember = partyMember;
        PartyMember memberScript = partyMember.GetComponent<PartyMember>();
        name = memberScript.name;
        isFlipped = memberScript.isFlippedState();
        nameText.text = name;
        dropdownOptions.ClearOptions();
        dropdownOptions.AddOptions(memberScript.states);
    }

    private void Update()
    {
        switch (dropdownOptions.value)
        {
            case 0:
                Debug.Log("Idle");
                break;
            case 1:
                Debug.Log("Sleep");
                break;
            case 2:
                Debug.Log("BattlePose");
                break;
        }
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
