using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chessman : MonoBehaviour
{
    public int CurrentX { set; get; }
    public int CurrentY { set; get; }
    public bool isWhite;

    //Positioning of Pieces
    public void SetPosition(int x, int y)
    {
        CurrentX = x;
        CurrentY = y;
    }

    //Boundaries for pieces and board
    public virtual bool[,] PossibleMove()
    {
        return new bool[8,8];
    }
	
}
