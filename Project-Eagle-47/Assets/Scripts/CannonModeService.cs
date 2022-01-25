using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonModeService : MonoBehaviour
{
    public IOService ioService;
    [SerializeField] GameObject Standard;
    [SerializeField] GameObject Rotating;
    private bool rotaing = false;
    // Start is called before the first frame update
    void Start()
    {
        getCannon();
        buttonSprite();
        AudioListener.pause = rotaing;
    }

    public void OnButtonPress()
    {
        if (!rotaing)
        {
            rotaing = true;
        }
        else
        {
            rotaing = false;
        }
        setCannon();
        buttonSprite();
    }
    private void getCannon()
    {
        rotaing = ioService.getInt(LocalFile.CANNON) == 1;
    }

    private void setCannon()
    {
        ioService.setCannon(rotaing ? 1 : 0);
    }

    private void buttonSprite()
    {
        if (!rotaing)
        {
            Standard.SetActive(true);
            Rotating.SetActive(false);
        }
        else
        {
            Standard.SetActive(false);
            Rotating.SetActive(true);
        }
    }
}
