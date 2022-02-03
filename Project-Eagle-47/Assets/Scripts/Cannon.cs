using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    float rotationGeschwindigkeit = 0.33f;
    int rotationsVorzeichen = 1;
    void Start()
    {

    }

    
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        var rotation = gameObject.transform.localRotation.eulerAngles.z;
        if (rotation < 320 && rotation > 40)
        {
            rotationsVorzeichen *= -1;
        }
        gameObject.transform.Rotate(0, 0, rotationGeschwindigkeit * rotationsVorzeichen);
    }

    public float getRotation()
    {
        return gameObject.transform.localRotation.eulerAngles.z;
    }
    
}


