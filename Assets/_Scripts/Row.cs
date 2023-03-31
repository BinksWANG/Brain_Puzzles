using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    public int rowIndex;

    private void Start()
    {
        rowIndex = int.Parse(gameObject.name);
    }
}
