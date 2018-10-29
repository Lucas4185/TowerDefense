using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public grid gridfab;

    public Vector2Int gridpos;

	// Use this for initialization
	void Start () {
        gridpos = new Vector2Int(0, 0);
        StartCoroutine("movement");
	}

    IEnumerator movement()
    {
        yield return new WaitForSeconds(1);

        transform.position = gridfab.nodeGrid[0, 0].position;
        yield return new WaitForSeconds(1);
        while (true)
        {
            if(gridfab.nodeGrid[gridpos.x, gridpos.y].direction != Vector3.zero)
            {
                transform.position += gridfab.nodeGrid[gridpos.x, gridpos.y].direction;
                gridpos = new Vector2Int(gridpos.x + (int)gridfab.nodeGrid[gridpos.x, gridpos.y].direction.x, gridpos.y + (int)gridfab.nodeGrid[gridpos.x, gridpos.y].direction.y);
            }
            yield return new WaitForSeconds(1);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
