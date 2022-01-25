using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public SceneService sceneService;
    public void StartGame()
    {
        sceneService.ChangeScene(Scenetype.GAME);
        audio.Play();
    }
}
