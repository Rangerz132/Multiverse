using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunnelGenerator : MonoBehaviour

{
    public Transform Hangard;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(Hangard, new Vector3(1.8f, 0,18*i), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
