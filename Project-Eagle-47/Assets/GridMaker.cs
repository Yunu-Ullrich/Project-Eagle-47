using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour
{
    private int rows 8;
    private int coloums = 4;
    private int ballSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }
    private void GenerateGrid()
    {
        GameObject referenceBall = (GameObject)Istantiate(Resources.Load("Ball Red"));
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < coloums; col++)
            {
                GameObject ball = (GameObject)Istantiate(referenceBall, transform);

                int posX = col * ballSize;
                int posY = row * -ballSize;

                ball.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(referenceBall);

        float gridW = coloums * ballSize;
        float gridH = rows * ballSize;
        transform.position = new Vector2(-gridW / 2 + ballSize / 2, gridH / 2 - ballSize / 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

