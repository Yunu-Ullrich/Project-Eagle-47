using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    int[,] grid = new int[9, 15];
    List<IGridListener> registry = new List<IGridListener> {};
    List<Position> souroundingGems = new List<Position> 
    {  
        new Position(0,-1),
        new Position(1,0),
        new Position(0,1),
        new Position(-1,0)
    };

    void Start()
    {
        Debug.Log("creating testGrid");
        testGrid();
    }
    public void registerGridListener(IGridListener igridListener)
    {
        registry.Add(igridListener);
    }

    public void unRegisterGridListener(IGridListener igridListener)
    {
        registry.Remove(igridListener);
    }

    public void testGrid()
    {
        int colour;
        for (int i = 0; i<grid.GetLength(0); i++)
        {
            for (int j = 0; j<grid.GetLength(1) - 5; j++)
            {
                colour = Random.Range(1, 7);
                addGemUnchecked(i, j, colour);
            }
        }
         
    }

    public void addGem(int x, int y, int status)
    {
        addGemUnchecked(x, y, status);
        checkGrid(x, y, status);
    }

    private void addGemUnchecked(int x, int y, int status)
    {      
        grid[x, y] = status;
        foreach (IGridListener gridListener in registry)
        {
            gridListener.gridInfo(x, y, status);
        }
    }

    public void checkGrid(int x, int y, int status)
    {
        var positions = new List<Position>();
        checkSouroundingGem(x, y, status, positions);

        if (positions.Count > 2)
        {
            foreach(Position pos in positions)
            {
                addGemUnchecked(pos.X(), pos.Y(), 0);
            }
        }
    }

    private void checkSouroundingGem(int x, int y, int status, List<Position> positions)
    {
        positions.Add(new Position(x, y));
        evaluateGems(x, y, status, positions);
    }

    private void evaluateGems(int x, int y, int status, List<Position> positions)
    {
        foreach(Position position in souroundingGems)
        {
            evaluatePosition(x, y, status, positions, position);
        }
    }

    private void evaluatePosition(int x, int y, int status, List<Position> positions, Position position)
    {
        int posX = x + position.X();
        int posY = y + position.Y();
        if (!(posX < 0 || posY < 0 || posY > grid.GetLength(1) -1 || posX > grid.GetLength(0) -1))
        {
            int newstatus = grid[posX, posY];

            bool alreadyExist = false;
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
    //TODO bool isGemAt(x, y)

}

