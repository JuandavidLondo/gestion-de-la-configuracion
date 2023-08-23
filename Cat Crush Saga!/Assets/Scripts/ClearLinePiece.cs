using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLinePiece : ClearablePiece
{
    public bool isRow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Clear()
    {
        base.Clear();
        if (isRow)
        {
            piece.Gridref.ClearRow(piece.Y);
        }
        else
        {
            piece.Gridref.ClearColumn(piece.X);
        }
    }
}
