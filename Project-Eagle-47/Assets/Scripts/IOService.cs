using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IOService : MonoBehaviour
{
    private Dictionary<LocalFile, string> LocalFileZuStringUmwandler =
        new Dictionary<LocalFile, string>();
    
    void Start()
    {
        SetupDictionary();
    }

    public void setHighscore(int pInt)
    {
        setInt(pInt, LocalFile.HIGHSCORE);
    }

    public void setSound(int pInt)
    {
        setInt(pInt, LocalFile.SOUND);
    }

    public void setCannon(int pInt)
    {
        setInt(pInt, LocalFile.CANNON);
    }

    public void setDifficulty(string pString)
    {
        string key;
        LocalFileZuStringUmwandler.TryGetValue(LocalFile.DIFFICULTY, out key);
        PlayerPrefs.SetString(key, pString);
    }

    public void setInt(int pInt, LocalFile file)
    {
        string key;
        LocalFileZuStringUmwandler.TryGetValue(file, out key);
        PlayerPrefs.SetInt(key, pInt);
    }

    public int getInt(LocalFile file)
    {
        string key;
        LocalFileZuStringUmwandler.TryGetValue(file, out key);
        return PlayerPrefs.GetInt(key);
    }
    
    public string getString(LocalFile file)
    {
        string key;
        LocalFileZuStringUmwandler.TryGetValue(file, out key);
        return PlayerPrefs.GetString(key);
    }


    private void SetupDictionary()
    {
        LocalFileZuStringUmwandler.Add(LocalFile.CANNON, "Cannon");
        LocalFileZuStringUmwandler.Add(LocalFile.HIGHSCORE, "Highscore");
        LocalFileZuStringUmwandler.Add(LocalFile.DIFFICULTY, "Difficulty");
        LocalFileZuStringUmwandler.Add(LocalFile.SOUND, "Sound");
    }
}
