using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    float rotation = 0.33f;
    bool richtung = true;
    void Start()
    {

    }

    
    void Update()
    {
        rotate();
    }

    private void rotate()
    {
        int vz = 1;
        for (richtung)
        {
            gameObject.transform.Rotate(0, 0, rotation* vz);
            Debug.Log("GetRotation: "+getRotation());
        }
        if (gameObject.transform.localRotation.eulerAngles.z < 320 || gameObject.transform.localRotation.eulerAngles.z > 40)
        {
            Debug.Log("GetRotation: " + getRotation());
            Debug.Log("Vz: " + vz);
            vz = vz * -1;
            Debug.Log("Richtung: " + richtung);
        }

    }

    private float getRotation()
    {
        return gameObject.transform.localRotation.eulerAngles.z;
    }
    
}


