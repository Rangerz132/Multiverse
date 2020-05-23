using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;


public class faceSmokeBehavior : MonoBehaviour
{
    private VisualEffect myEffect;
    public static bool isFading = false;
    public float faceSmokeValue = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        myEffect = GetComponent<VisualEffect>();


    }

    // Update is called once per frame
    void Update()
    {
        if (isFading)
        {
            myEffect.SetFloat("spawnRate", faceSmokeValue);
        }

        else
        {
            myEffect.SetFloat("spawnRate", 0);
        }
    }
}
