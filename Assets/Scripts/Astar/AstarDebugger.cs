using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstarDebugger : MonoBehaviour {

    [SerializeField]
    private TileScript start, goal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ClickTile();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Astar.GetPath(start.GridPosition);
        }
	}

    private void ClickTile()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if(hit.collider != null)
            {
                TileScript tmp = hit.collider.GetComponent<TileScript>();

                if( tmp != null)
                {
                    if (start == null)
                    {
                        start = tmp;
                        start.Debug = true;
                        start.ColorTile(Color.black);
                    } else if (goal == null)
                    {
                        goal = tmp;
                        goal.Debug = true;
                        goal.ColorTile(Color.magenta);
                    }
                }
            }
        }
    }

    public void DebugPath(HashSet<Node> openList)
    {
        foreach (Node node in openList)
        {
            if (node.TileRef != start)
            {
                node.TileRef.spriteRenderer.color = Color.clear;
                //node.TileRef.spriteRenderer.sprite = blankTile;
            }
        }
    }
  
}
