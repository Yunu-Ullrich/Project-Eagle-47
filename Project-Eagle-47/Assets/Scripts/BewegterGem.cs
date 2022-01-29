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
    void Start()
    {

    }

    void Update()
    {
        /*CalculateNextPosition();
        CheckCollisionWall(a);
        c= CheckCollisionGem(a);
        if(b)
        {
            collideWithWall();
        }
        else if(c)
        {
            collideWithGem();
        }
        else
        {
            moveBall();
        }*/
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

    }

    private bool CheckCollisionGem(Vector2 Pos)
    {

    }

    private void CollideWithWall(Vector2 Pos)
    {

    
    }
    
    private void CollideWithGem(Vector2 Pos)
    {

    }
    
    private void MoveGem(Vector2 nextPos)
    {

    }

    public void gridInfo(int x, int y, int status)
    {
        ;
    }
}
