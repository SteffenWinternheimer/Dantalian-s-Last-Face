using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
    bool isBeingDragged;

    MouseBehavior mouseBehavior;
    private void Start()
    {
        mouseBehavior = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseBehavior>();
    }
    private void Update()
    {
        if (isBeingDragged)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }

    private void OnMouseDown()
    {
        isBeingDragged = true;
        //if theres a party member panel in the scene, destroy it and reset the boolean to prevent bugs
        if (GameObject.FindGameObjectWithTag("PartyMemberPanel"))
        {
            Destroy(GameObject.FindGameObjectWithTag("PartyMemberPanel"));
            mouseBehavior.isPanelActive = false;

        }
        
    }
    private void OnMouseUp()
    {
        isBeingDragged = false;
    }

    public bool isDragged()
    {
        return isBeingDragged;
    }

}
