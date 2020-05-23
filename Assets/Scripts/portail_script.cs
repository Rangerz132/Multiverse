using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portail_script : MonoBehaviour
{

    public Vector3 SpeedPortal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //We change the Y axis because we rotate earlier;
        SpeedPortal = new Vector3(0f, 5f * Time.deltaTime, 0f );

        transform.Translate(SpeedPortal);
    }
}
