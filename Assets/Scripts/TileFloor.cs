﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFloor : MonoBehaviour
{
    public bool isPlaceable = true;

    Vector2Int gridPos;

    const int gridSize = 10;

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize),
            Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<PlayerMovement>().AddStep(this);
        }
    }
}
