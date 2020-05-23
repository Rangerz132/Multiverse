using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class ringBehavior : MonoBehaviour

{
    public VisualEffect myEffect;
    public  float seedRadius = 1f;

    public  float speedRadius;
    public  float seedY = 1f;
    public  float speedY = 1f;

    private float LFO;

    // Start is called before the first frame update
    void Start()
    {
        myEffect = GetComponent<VisualEffect>();

    }

    // Update is called once per frame
    void Update()

    {
        myEffect.SetFloat("PosY", Mathf.Sin(Time.time *speedY)*seedY);
        myEffect.SetFloat("Radius", Mathf.Abs(Mathf.Sin(Time.time * speedRadius)*seedRadius));

    }
}
