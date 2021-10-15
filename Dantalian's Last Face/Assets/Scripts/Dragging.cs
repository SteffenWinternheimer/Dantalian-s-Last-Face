using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragging : MonoBehaviour
{
    bool isBeingDragged;
    public SpriteRenderer spriteRenderer;

    public Color originalColor;
    public Color selectedColor;

    MouseBehavior mouseBehavior;
    private void Start()
    {
        GameObject child = transform.GetChild(0).gameObject;
        spriteRenderer = child.GetComponent<SpriteRenderer>();
        originalColor = new Color(1, 1, 1, 1);
        selectedColor = new Color(0, 1, 1, 1);
        mouseBehavior = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseBehavior>();
    }
    private void Update()
    {
        
        if (isBeingDragged)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            spriteRenderer.color = selectedColor;
        }
        else if(spriteRenderer != null)
        {
            spriteRenderer.color = originalColor;
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
