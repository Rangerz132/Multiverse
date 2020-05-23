using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
public class randomizeRing : MonoBehaviour
{
    // Start is called before the first frame update
    private VisualEffect vfx;
    private GameObject go;

    void Start()
    {
     //   go.ringBehavior. = Random.Range(-1, 1);
     // ringBehavior.seedRadius = Random.Range(-5, 6);
     //ringBehavior.speedRadius = Random.Range(-5, 6);
     //ringBehavior.speedRadius = Random.Range(-5, 6);

       GetComponent<ringBehavior>().seedRadius = Random.Range(-5f,5f);
        GetComponent<ringBehavior>().speedRadius = Random.Range(-5f, 5f);
        GetComponent<ringBehavior>().seedY = Random.Range(-5f, 5f);
        GetComponent<ringBehavior>().speedY = Random.Range(-5f, 5f);





    }

    // Update is called once per frame
    void Update()
    {
    }
}
