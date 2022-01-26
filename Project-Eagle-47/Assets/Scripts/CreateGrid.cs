using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid
{
    int[,] grid = new int[3, 4];
    List<Position> leftpos = new List<Position> { 
        new Position(-1,-1), 
        new Position(0,- 1),
        new Position(1,0),
        new Position(0,1),
        new Position(-1,1),
        new Position(-1,0)};
    List<Position> rightpos = new List<Position> { 
        new Position(-1,0), 
        new Position(1,0),
        new Position(0,-1),
        new Position(1,-1),
        new Position(0,1),
        new Position(1,1)};

    public void testGrid()
    {
        for (int i = 0; i<grid.Length; i++)
        {
            for (int j = 0; j<grid.GetLength(1); j++)
            {
                grid[i, j] = 1;
            }
        }
         
    }

    private void addGemUnchecked(int x, int y, int status)
    {      
        grid[x, y] = status;
    }

    public List<Position> checkGrid(int x, int y, int status)
    {
        var positions = new List<Position>();
        checkSouroundingGem(x, y, status, positions);

        // TODO continue
        return positions;
    }

    private void checkSouroundingGem(int x, int y, int status, List<Position> positions)
    {
        positions.Add(new Position(x, y));
        bool left = evaluateIndent(y);
        if (left)
        {
            evaluateLeft(x, y, status, positions);
        }
        else
        {
            evaluateRight(x, y, status, positions);
        }
    }

    public bool evaluateIndent(int y)
    {
        if (y % 2 == 0)
        {
            return true;
        }
        return false;
    }

    private void evaluateLeft(int x, int y, int status, List<Position> positions)
    {
        foreach(Position position in leftpos)
        {
            evaluatePosition(x, y, status, positions, position);
        }
    }
    
    private void evaluateRight(int x, int y, int status, List<Position> positions)
    {
        foreach (Position position in rightpos)
        {
            evaluatePosition(x, y, status, positions, position);
        }
    }

    private void evaluatePosition(int x, int y, int status, List<Position> positions, Position position)
    {
        int posX = x + position.X();
        int posY = y + position.Y();
        int newstatus = grid[posX, posY];
        bool alreadyExist = positions.Contains(new Position(posX, posY));
        if (newstatus == status)
        {
            foreach (Position position1 in positions)
            {
                if (position1.X() == posX && position1.Y() == posY)
                {
                    alreadyExist = true;
                }
            }
            if (alreadyExist == false)
            {
                positions.Add(new Position(posX, posY));
                checkSouroundingGem(posX, posY, status, positions);
                }
        }
    }

}

