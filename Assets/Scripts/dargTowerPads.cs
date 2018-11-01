using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dargTowerPads : MonoBehaviour {

    public GameObject PanelToShow;
    public GameObject chooseTile;
    float distance = 10;
    private bool button = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDrag()
    {

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        PanelToShow.SetActive(true);
        button = true;

    }

    private void changeTile()
    {
        if(button == true)
        {
            chooseTile.SetActive(true);
        }
    }

}
