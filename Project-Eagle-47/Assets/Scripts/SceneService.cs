using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneService : MonoBehaviour
{
    private Dictionary<Scenetype, string> scenetypeZuStringUmwandler =
        new Dictionary<Scenetype, string>();
    
    // Start is called before the first frame update
    void Start()
    {
        SetupDictionary();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(Scenetype scenetype)
    {
        string scenename;
        scenetypeZuStringUmwandler.TryGetValue(scenetype, out scenename);
        SceneManager.LoadScene(scenename);
    }

    private void SetupDictionary()
    {
        scenetypeZuStringUmwandler.Add(Scenetype.MAINMENU, "StartMenu");
        scenetypeZuStringUmwandler.Add(Scenetype.GAME, "SampleScene");
    }
}
