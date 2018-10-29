using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dargTowerPads : MonoBehaviour {

    public GameObject PanelToShow;
    float distance = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        PanelToShow.SetActive(true);

    }

}
