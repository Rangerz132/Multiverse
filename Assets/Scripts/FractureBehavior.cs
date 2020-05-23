using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractureBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxScale;
    public Material frac;
    public float speedFade =1;
    static float t = 0;
    private Vector3 myTranslate,offset,shipPos;
    private GameObject theShip;
    public float offesetZ;
    public static  bool isFadingIn =false;


    void Start()
    {
          isFadingIn = false;

    theShip = GameObject.FindGameObjectWithTag("Player");
        frac = GetComponent<Renderer>().material;
        frac.SetFloat("_fadeValue", 0f);
        myTranslate = new Vector3(0f, 0f, .1f);
      offset = new Vector3(0f, 0f,30f);
        


    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if(!isFadingIn) shipPos = theShip.transform.position;

        if (Input.GetKey("j")) { isFadingIn = true; }
        if (isFadingIn) {
            //frac.SetFloat("_fadeValue", Mathf.Lerp(.5f,0,t));

            // t += speedFade*Time.deltaTime;
            transform.localScale += new Vector3(.01f, .01f, .01f)*speedFade;

        }

        if (transform.localScale.x <=10)
        {
            transform.position = shipPos + offset;

        }

        if (transform.localScale.x >= 10)
        {
            transform.position -= myTranslate;
        }

        if (transform.position.z<-1)
        {
            isFadingIn = false;
            transform.localScale = new Vector3(.01f, .01f, .01f);
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isFadingIn = false;

            playerController.isFastEnough = true;
        }
    }
}
