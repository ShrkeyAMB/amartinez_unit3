using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obst;
    private Vector3 spawnPos = new Vector3(30, 0, 0);
    private PlayerController playerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObst",2,2);
        playerCtrl = GameObject.Find("Player").GetComponent<PlayerController>();

    }

   
    void spawnObst()
    {
        if (playerCtrl.gameOver == false)
        {
            Instantiate(obst, spawnPos, obst.transform.rotation);
        }
    }
}
