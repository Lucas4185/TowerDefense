using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{

    public Vector2 size;
    private Vector3 tileSize;
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
        Vector3 tileSize = new Vector3(0, 0, 0);
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject aTitle = Instantiate(Resources.Load("TowerDefense/GridPiece2") as GameObject);
                aTitle.transform.position = new Vector3(
                   (tileSize.x + 10) * i, 0,
                   (tileSize.z + 10) * j
                );
            }
        }
    }
}
