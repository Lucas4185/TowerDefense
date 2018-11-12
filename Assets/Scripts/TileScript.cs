using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
    }

    private void PlaceTower()
    {

        //Deze code werkt alleen als de muis niet over een GameObject is zo weet het dat als je op een button clicked om een tower te kiezen dat hij geen tower moet plaatsen
        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
        {
           GameObject tower = Instantiate(GameManager.Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab), transform.position, Quaternion.identity);

            tower.GetComponent<SpriteRenderer>().sortingOrder = GridPosition.y; 
        }
    }
}
