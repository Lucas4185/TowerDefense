using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBtn : MonoBehaviour {

    [SerializeField]
    private GameObject towerPrefab;

    //Dit is zidat je toch een private object kan halen maar niet kan veranderen
    public GameObject TowerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
