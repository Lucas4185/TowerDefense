using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TileScript : MonoBehaviour {

    public Point GridPosition { get; private set; }

    public SpriteRenderer spriteRenderer { get; set; }

    private Color32 fullColor = new Color(255, 118, 118, 255);

    private Color32 emptyColor = new Color(96, 255, 90, 255);

    public bool isEmpty { get; private set; }

    public bool Debug { get; set; }

    public bool walkAble { get; set; }

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(Point gridPos, Vector3 worldPos, Transform parent) {

        walkAble = true;
        isEmpty = true;
        this.GridPosition = gridPos;     
        transform.position = worldPos;
        transform.SetParent(parent);    
        LevelManager.Instance.Tiles.Add(gridPos, this);

        
      
        //LevelManager.Instantiate.Tiles.Add(gridPos, this);
    }

    private void OnMouseOver()
    {
        
        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null) {
            if (isEmpty && !Debug)
            {
                ColorTile(Color.blue);
            }

            if (!isEmpty && !Debug)
            {
                ColorTile(Color.red);
            }
          
            else if (Input.GetMouseButtonDown(0))
            {
                PlaceTower();
                //Debug.Log(GridPosition.x + ", " + GridPosition.y);
            }
        }
    }

    private void OnMouseExit()
    {
        if (!Debug)
        {
            ColorTile(Color.white);
        }
    }

    private void PlaceTower()
    {

        //Deze code werkt alleen als de muis niet over een GameObject is zo weet het dat als je op een button clicked om een tower te kiezen dat hij geen tower moet plaatsen
        if (!EventSystem.current.IsPointerOverGameObject() && GameManager.Instance.ClickedBtn != null)
        {
           GameObject tower = Instantiate(GameManager.Instantiate(GameManager.Instance.ClickedBtn.TowerPrefab), transform.position, Quaternion.identity);

            tower.GetComponent<SpriteRenderer>().sortingOrder = 5;
            isEmpty = false;
            ColorTile(Color.white);

            Hover.Instance.Deactivate();

            walkAble = false;
        }
    }
    public void ColorTile(Color newColor)
    {
        spriteRenderer.color = newColor;
    }
}
