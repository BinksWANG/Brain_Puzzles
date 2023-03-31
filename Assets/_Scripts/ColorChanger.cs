using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public bool isWrite = true;
    public int colIndex;
    public int rowIndex;

    private Image _image;
    private GameObject _row;

    private void Start()
    {
        
        _image = gameObject.GetComponent<Image>();
        _image.color = Color.white;
        _row = transform.parent.gameObject;
        colIndex = int.Parse(gameObject.name);
        rowIndex = _row.GetComponent<Row>().rowIndex;
    }

    public void Click()
    {
        Coloring();
        NeighborColoring();
    }

    private void NeighborColoring()
    {
        // left and right
        var leftAndRight = _row.GetComponentsInChildren<ColorChanger>();
        foreach (var child in leftAndRight) 
        {
            if (child.colIndex == colIndex - 1 || child.colIndex == colIndex + 1) 
            {
                child.Coloring();
            }
        }

        // top and bot
        var parent = _row.transform.parent;
        var topAndBot = parent.GetComponentsInChildren<Row>();
        foreach (var child in topAndBot) 
        {
            if (child.rowIndex == rowIndex + 1 || child.rowIndex == rowIndex - 1) 
            {
                foreach (var c in child.GetComponentsInChildren<ColorChanger>()) 
                {
                    if (c.colIndex == colIndex)
                        c.Coloring();
                }
            }
        }
    }

    public void Coloring()
    {
        if (isWrite)
        {
            _image.color = Color.black;
            isWrite = false;
        }
        else 
        {
            _image.color = Color.white;
            isWrite = true;
        }
    }
}
