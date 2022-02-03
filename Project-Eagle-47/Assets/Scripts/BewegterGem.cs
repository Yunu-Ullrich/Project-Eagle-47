using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BewegterGem : MonoBehaviour, IGridListener
{
    //transform.position += transform.forward* Time.deltaTime * 10.0f;
    public const float WALLTOP = 4.5f;
    public const float WALLLEFT = 2;
    public const float WALLRIGHT = 6;
    Cannon cannon = new Cannon();
    void Start()
    {

    }

    void Update()
    {
        
        var a = CalculateNextPosition(cannon.getRotation(), 0.01f, new Vector2(1.99f, -6.79f));
        bool b = CheckCollisionWall(a);
        bool c = CheckCollisionGem(a);
        if(b)
        {
            CollideWithWall(a);
        }
        else if(c)
        {
            CollideWithGem(a);
        }
        else
        {
            MoveGem(a);
        }
    }

    private Vector2 CalculateNextPosition(float richtungsVector, float velocity, Vector2 currentPosition)
    {
        double a = Math.Sin(richtungsVector) * velocity;
        double b = Math.Cos(richtungsVector) * velocity;
        double nextX = b + currentPosition.x;
        double nextY = a + currentPosition.y;
        return new Vector2((float)nextX, (float)nextY);
    }

    private void Refresh()
    {
        
    }

    private bool CheckCollisionWall(Vector2 Pos)
    {
        float xLeft = -0.03f;
        float xRight = 4.02f;
        if (Pos.x <= xLeft || Pos.x >= xRight) {
            return true;
        }
        return false;
    }

    private bool CheckCollisionGem(Vector2 Pos)
    {
        return true;
    }

    private void CollideWithWall(Vector2 Pos)
    {
        var a = CalculateNextPosition(360 - cannon.getRotation() , 0.01f, new Vector2(1.99f, -6.79f));
        MoveGem(a);
    }
    
    private void CollideWithGem(Vector2 Pos)
    {

    }
    
    private void MoveGem(Vector2 nextPos)
    {
        gameObject.transform.position = nextPos;
    }

    public void gridInfo(int x, int y, int status)
    {
        
    }
}
