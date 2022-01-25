using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundService : MonoBehaviour
{
    public IOService ioService;
    [SerializeField] GameObject soundIcon;
    [SerializeField] GameObject soundOffIcon;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        getSound();
        buttonSprite();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if (!muted)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        setSound();
        buttonSprite();
    }
    private void getSound()
    {
        muted = ioService.getInt(LocalFile.SOUND) == 1;
    }

    private void setSound()
    {
        ioService.setSound(muted ? 1 : 0);
    }

    private void buttonSprite()
    {
        if (!muted)
        {
            soundIcon.SetActive(true);
            soundOffIcon.SetActive(false);
        }
        else
        {
            soundIcon.SetActive(false);
            soundOffIcon.SetActive(true);
        }
    }
    
}
