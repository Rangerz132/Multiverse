using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_anim : MonoBehaviour
{

    public GameObject cube_test;
   

    void Start()
    {
       
    }


    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "temp_floor") {

            Instantiate(cube_test, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

}
