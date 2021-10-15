using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    public Vector2 gridSize = default;
    public SpriteRenderer spriteRenderer;
    private void Update()
    {
        
        spriteRenderer.sortingOrder = Mathf.RoundToInt(-transform.position.y);
        SnapToGrid();
    }

    //private void OnDrawGizmos()
    //{
    //    SnapToGrid();
    //}

    private void SnapToGrid()
    {
        var position = new Vector2(
                Mathf.RoundToInt(this.transform.position.x / this.gridSize.x),
                Mathf.RoundToInt(this.transform.position.y / this.gridSize.y)
            );

        this.transform.position = position;
    }
}
