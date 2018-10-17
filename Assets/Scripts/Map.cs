using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    private int[,] numbers;



    void Start()
    {

        numbers = new int[10, 10];



        numbers[0, 1] = 8;

        numbers[0, 2] = 5;

        numbers[1, 3] = 7;

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void objInGrid()
    {

    }
}
