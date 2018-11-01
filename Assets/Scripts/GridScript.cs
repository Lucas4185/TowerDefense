using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] tilePrefab;
    public int xPos;
    public int yPos;

    public float TileSize
    {
      get { return tilePrefab[0].GetComponent<SpriteRenderer>().bounds.size.x; }
    }

    // Use this for initialization
    void Start()
    {
        mapMaker();
    }


    // Update is called once per frame
    void Update()
    {

    }


    private void mapMaker()
    {

        string[] mapData = ReadLevelText();

        int mapXsize = mapData[0].ToCharArray().Length;
        int mapYsize = mapData.Length;

        //zorgt er voor dat de grid goed in de camera spawned
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(25, Screen.height));

        for (int y = yPos; y < mapYsize; y++)
        {

            char[] newTiles = mapData[y].ToCharArray();
            for(int x = xPos; x < mapXsize; x++)
            {
                PlaceTile(newTiles[x].ToString(), x,y, worldStart);
            }
        }
       
    }

    //dit maakt de tile en zet hem op de goede plek
    private void PlaceTile(string tileType, int x, int y, Vector3 worldStart)
    {
        int tileIndex = int.Parse(tileType);
        GameObject newTile = Instantiate(tilePrefab[tileIndex]);
        newTile.transform.position = new Vector3(worldStart.x + (TileSize * x), worldStart.y - (TileSize * y), 0);
    }


    //deze functie zorgt er voor dat de Level.txt in de Resources folder geladen word
    private string[] ReadLevelText()
    {
        TextAsset data = Resources.Load("Level") as TextAsset;

      string  tmpData = data.text.Replace(Environment.NewLine, string.Empty);

        return tmpData.Split('-');
    }
}
