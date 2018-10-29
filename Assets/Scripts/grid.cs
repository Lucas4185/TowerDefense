using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour {

    public node[,] nodeGrid;

    public GameObject cube;

    public int gridX;
    public int gridY;

	// Use this for initialization
	void Start () {
        nodeGrid = new node[gridX, gridY];
        for (int i = 0; i < gridX; i++)
        {
            for (int j = 0; j < gridY; j++)
            {
                Vector3 vec = new Vector3(i, 0, j);
                GameObject newNode = Instantiate(cube,vec,Quaternion.identity);
                newNode.AddComponent<node>();
                nodeGrid[i, j] = newNode.GetComponent<node>();
                nodeGrid[i, j].position = new Vector3(i, 0, j);
            }
        }		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
