using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insideRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 180f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
