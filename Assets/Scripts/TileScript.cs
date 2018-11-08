using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

    public Point GridPosition { get; private set; }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(Point gridPos, Vector3 worldPos, Transform parent) {

        this.GridPosition = gridPos;     
        transform.position = worldPos;
        transform.SetParent(parent);    
        LevelManager.Instance.Tiles.Add(gridPos, this);

        
      
        //LevelManager.Instantiate.Tiles.Add(gridPos, this);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceTower();
            //Debug.Log(GridPosition.x + ", " + GridPosition.y);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Lucas is awesome");
        }
    }

    private void PlaceTower()
    {
        Debug.Log("Brandon is gay moto");
    }
}
