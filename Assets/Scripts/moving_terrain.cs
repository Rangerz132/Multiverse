using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_terrain : MonoBehaviour
{
    public float speed = -15f;
    public static float speedTranslate;
    // Start is called before the first frame update
    void Start()
    {
        speedTranslate = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speedTranslate * Time.deltaTime, Space.Self);
    }
}
