using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundService : MonoBehaviour
{
    public IOService ioService;
    [SerializeField] Image SoundButton;
    [SerializeField] Image NoSoundButton;
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
        if (muted == false)
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
        if (muted == false)
        {
            SoundButton.enabled = true;
            NoSoundButton.enabled = false;
        }
        else
        {
            SoundButton.enabled = false;
            NoSoundButton.enabled = true;
        }
    }
    
}
