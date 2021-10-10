using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseBehavior : MonoBehaviour
{
    public LayerMask ignoreLayer;
    public GameObject partyMemberPanel;
    public GameObject canvas;
    public bool isPanelActive;
    GameObject activePanel;
    public bool isPlayerHooked;

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(1))
        {
            if (!EventSystem.current.IsPointerOverGameObject())           
                CheckMouseClick();
        }

    }

    void CheckMouseClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, ignoreLayer);



        if(hit)
        {
            if (hit.collider.tag == "PartyMember" && !isPanelActive)
            {
                GameObject partyMember = hit.collider.gameObject;
                
                Vector3 mousePos = Input.mousePosition;
                CreatePanel(mousePos, partyMember);

            }
        }
        else
        {
            isPanelActive = false;
            Destroy(activePanel);
        }

    }


    void CreatePanel(Vector3 mousePos, GameObject partyMember)
    {
        activePanel = Instantiate(partyMemberPanel, mousePos, Quaternion.identity);
        activePanel.transform.SetParent(canvas.transform); 
        RectTransform transform = activePanel.GetComponent<RectTransform>();
        transform.position = new Vector3(transform.position.x + 33, transform.position.y - 30);
        isPanelActive = true;
        activePanel.GetComponent<PartyMemberPanel>().AssignInformationToPanel(partyMember);
    }

}
