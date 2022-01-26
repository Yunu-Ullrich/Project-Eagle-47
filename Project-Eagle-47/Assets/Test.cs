using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid cG = new CreateGrid();
        cG.testGrid();
        List<Position> list = cG.checkGrid(0, 0, 1);
        list.ForEach(LogIt);
    }

    private void LogIt(Position position)
    {
        Debug.Log("Position x: " + position.X() + " | y:" + position.Y());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
