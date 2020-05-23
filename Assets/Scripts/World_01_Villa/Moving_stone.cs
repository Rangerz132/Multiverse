using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_stone : MonoBehaviour
{
    public static float speedTranslate;
    public float speedTranslater = -15f;
    public float speedRotate;
    public bool isRotating = true;
    public bool isRotationAtSpawn = true;
    public bool canBeDestroyed = true;
    public bool globalAxis = false;
    public float lifeTime = 15f;

    public float maxRotate;
    public float minRotate;


    // Start is called before the first frame update
    void Start()
    {
        speedTranslate = speedTranslater;
        //random rotation at spawn
        if (isRotationAtSpawn) {
            transform.Rotate(Random.Range(minRotate, maxRotate), Random.Range(minRotate, maxRotate), Random.Range(minRotate, 40f),Space.Self);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating) transform.Rotate(10f * Time.deltaTime, 0f, speedRotate * Time.deltaTime);
        if (globalAxis) transform.Translate(0f, 0f, speedTranslate * Time.deltaTime, Space.Self);
        if(!globalAxis) transform.Translate(0f, 0f, speedTranslate * Time.deltaTime, Space.World);
        if (canBeDestroyed == true) Destroy(gameObject, lifeTime);

    }
}
