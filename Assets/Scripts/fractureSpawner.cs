using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fractureSpawner : MonoBehaviour
{
    bool hasSpawned;
    private GameObject fract;
    public GameObject myShip;
    Vector3 posShip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        posShip = myShip.transform.position;
        transform.position = posShip;
        if (hasSpawned == true)
        {
        
        }
    }
}
