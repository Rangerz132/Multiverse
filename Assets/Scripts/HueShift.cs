using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;
using UnityEngine.Rendering.PostProcessing;



public class HueShift : MonoBehaviour
{

    ColorGrading colorGradingLayer = null;
    private float maxVal;


    void Start()
    {
        PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
   
        volume.profile.TryGetSettings(out colorGradingLayer);

        colorGradingLayer.enabled.value = true;

       

    }

    // Update is called once per frame
    void Update()
    {
        maxVal = Mathf.Sin(Time.time) * 180;
        colorGradingLayer.hueShift.value = maxVal;

    }
}
