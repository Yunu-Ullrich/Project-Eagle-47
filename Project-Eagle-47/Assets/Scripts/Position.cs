using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position
{
    private int x, y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X()
    {
        return x;
    }

    public int Y()
    {
        return y;
    }
}
