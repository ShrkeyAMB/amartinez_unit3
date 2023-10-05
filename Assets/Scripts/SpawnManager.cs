using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obst;
    private Vector3 spawnPos = new Vector3(30, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObst",2,2);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObst()
    {
        Instantiate(obst, spawnPos, obst.transform.rotation);
    }
}
