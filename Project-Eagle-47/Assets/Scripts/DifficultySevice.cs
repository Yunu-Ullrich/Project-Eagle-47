using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultySevice : MonoBehaviour
{
    public IOService ioService;
    [SerializeField] GameObject Easy;
    [SerializeField] GameObject Normal;
    [SerializeField] GameObject Hard;
    private int difficulty = 1;
    private string strDifficulty;
    // Start is called before the first frame update
    void Start()
    {
        getDifficulty();
        buttonSprite();
    }

    public void OnButtonPress()
    {
        difficulty += 1;

        if (difficulty > 3)
        {
            difficulty = 1;
        }

        setDifficulty(setStrDifficulty(difficulty));
        buttonSprite();
    }
    private void getDifficulty()
    {
        strDifficulty = ioService.getString(LocalFile.DIFFICULTY);
        Debug.Log("get difficulty setting strDifficulty: " + strDifficulty);
        if (strDifficulty.Equals("Easy"))
        {
            difficulty = 1;
        }
        else if (strDifficulty.Equals("Normal"))
        {
            difficulty = 2;
        }
        else
        {
            difficulty = 3;
        }
        Debug.Log("Difficulty after if strDifficulty: " + difficulty);
    }

    private void setDifficulty(string diff)
    {
        ioService.setDifficulty(diff);
    }

    private void buttonSprite()
    {
        if (difficulty == 1)
        {
            Easy.SetActive(true);
            Normal.SetActive(false);
            Hard.SetActive(false);
        }
        else if (difficulty == 2)
        {
            Easy.SetActive(false);
            Normal.SetActive(true);
            Hard.SetActive(false);
        }
        else
        {
            Easy.SetActive(false);
            Normal.SetActive(false);
            Hard.SetActive(true);
        }
    }
    private string setStrDifficulty(int pDifficulty)
    {
        Debug.Log("setStrDifficulty int Difficulty: " + pDifficulty);
        string difficulty;
        if (pDifficulty == 1)
        {
            difficulty = "Easy";
        }
        else if (pDifficulty == 2)
        {
            difficulty = "Normal";
        }
        else
        {
            difficulty = "Hard";
        }
        Debug.Log("setStrDifficulty string difficulty after if : " + difficulty);
        return difficulty;
    }
}
