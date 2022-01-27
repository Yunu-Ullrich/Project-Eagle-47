using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testButton : MonoBehaviour
{
    public CreateGrid gC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomGem()
    {
        gC.addGem(Random.Range(0, 9), Random.Range(5, 15), Random.Range(1, 7));
    }
}
