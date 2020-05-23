using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCam : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject Fracture;
    public Vector3 offset;
    public float wiggleRange = .01f;
    private float wiggleDist = 1;
    private Vector3 wiggle = new Vector3(0f,0f,0f);
    public float IncrementWiggle;
    public bool engagedFrac = false;

    void Start()
    {
       Fracture = GameObject.FindWithTag("Finish");
        engagedFrac = false;

        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
       


    }


    private void LateUpdate()
    {
       


        if (playerController.isHit == true && engagedFrac == false) 
        {
            wiggleRange = wiggleRange + .001f + IncrementWiggle;
            wiggle = new Vector3(Random.Range(-wiggleRange, wiggleRange), Random.Range(-wiggleRange, wiggleRange), Random.Range(-wiggleRange, wiggleRange));


            transform.position = Player.transform.position + offset + wiggle;

        }  

        if (FractureBehavior.isFadingIn == true) 
        {

            engagedFrac = true;
            wiggleRange = wiggleRange + .001f;
            wiggle = new Vector3(Random.Range(-wiggleRange, wiggleRange), Random.Range(-wiggleRange, wiggleRange), Random.Range(-wiggleRange, wiggleRange));


            transform.position = Player.transform.position + offset + wiggle;

        }
         
        if (FractureBehavior.isFadingIn == false && playerController.isHit == false) 
        {
            wiggleRange = .01f;
            transform.position = Player.transform.position + offset;
            engagedFrac = false;

        }

        else
        {
            
        }
        transform.rotation = Player.transform.rotation;







    }


}
