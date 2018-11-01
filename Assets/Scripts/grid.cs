using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour {

    public node[,] nodeGrid;
    public node[,] nodeGrid2;

    public GameObject cube;
    public GameObject path;

    public int gridX;
    public int gridY;

	// Use this for initialization
	void Start () {
        nodeGrid = new node[gridX, gridY];
        nodeGrid2 = new node[10, 5];

       
        Vector3 vec2 = new Vector3(10, -0.40f, 10);
        GameObject newPath = Instantiate(path, vec2, Quaternion.identity); 
        newPath.AddComponent<node>();
        nodeGrid2[1, 1] = newPath.GetComponent<node>();
        nodeGrid2[1, 1].position = new Vector3(5, 0, 10);

        for (int i = 0; i < gridX; i++)
        {
            for (int j = 0; j < gridY; j++)
            {
                Vector3 vec = new Vector3(i, -0.50f, j);
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
