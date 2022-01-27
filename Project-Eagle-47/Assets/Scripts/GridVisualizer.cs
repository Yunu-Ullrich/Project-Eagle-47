using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisualizer : MonoBehaviour, IGridListenerAS
{
    GameObject[,] gems = new GameObject[9, 15];
    float width = 0.5f;
    public CreateGrid cG;
    Dictionary<int, GameObject> farbe = new Dictionary<int, GameObject>();

    public void gridInfo (int x, int y, int status)
    {
        if(status == 0)
        {
            delete(x, y);
        }
        else
        {
            create(x, y, status);
        }
    }
    
    private void delete(int x, int y)
    {
        GameObject.Destroy(gems[x, y]);
    }

    private void create (int x, int y, int status)
    {
        GameObject gem;
        farbe.TryGetValue(status, out gem);
        var go = (GameObject)Instantiate(gem);
        gems[x, y] = go;
        float posX = x * width;
        float posY = y * width * -1;
        go.transform.position = new Vector2(posX, posY);
    }
    
    void Awake()
    {
        initDictionary();
        Debug.Log("registering cG");
        cG.registerGridListener(this);
    }

    private void initDictionary()
    {
        farbe.Add(1, Resources.Load("Gems/element_blue_diamond_glossy") as GameObject);
        farbe.Add(2, Resources.Load("Gems/element_green_diamond_glossy") as GameObject);
        farbe.Add(3, Resources.Load("Gems/element_grey_diamond_glossy") as GameObject);
        farbe.Add(4, Resources.Load("Gems/element_purple_diamond_glossy") as GameObject);
        farbe.Add(5, Resources.Load("Gems/element_red_diamond_glossy") as GameObject);
        farbe.Add(6, Resources.Load("Gems/element_yellow_diamond_glossy") as GameObject);
    }
}
