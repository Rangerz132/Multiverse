using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class playerController : MonoBehaviour
{
    public Rigidbody rb; //The ships rigidBody
    public GameObject myWindShield; // Over face windShield
   // public GameObject MyPortal;
   // public Transform emmitPortal;



    public OSC oscReference;

    public float MaxSpeedForward; //Speed at which the ship goes

    public float speedFade; // speed of The fade when the max speed is reached

    public float maxRotation = 30;
    public float minRotation = -30;

    float moveHorizontal;
    float moveVertical;


    public static bool isFastEnough = false; //Condition to switch between worlds
    public static bool isHit = false; // Condition for the wiggle on hit
    public bool isUsingJoyStick = false; //false for regular input.getaxis , true for 
    public static bool finishedAnim = true;


    public float speedH, speedV, offset;

    public float tilt;
    public Boundary boundary;

    private float t;


    //OSC MANAGING
    public float hValue,vValue,hValueLerped;
    public float Multiplier,lastVal;

    void Start()
    {

        //------------------------------------------OSC OUTPUTER-----------------------------------------------------------------
        OscMessage message = new OscMessage();
        message.address = "/test";
        message.values.Add(SceneManager.GetActiveScene().buildIndex);
        oscReference.Send(message);




        //-----If in final scene, do arrival anim
      


    //------------------------------------------OSC RECIEVER-----------------------------------------------------------------
        oscReference.SetAddressHandler("/hValue", hHandler);        
        oscReference.SetAddressHandler("/vValue", vHandler);      



    }





    void FixedUpdate()
    {

        //------------------------------------- BEGINING ----------------------------------------------
      
        if (Input.GetKey(KeyCode.Space) && globalVars.hasTakenOff == false)
        {
            rb.AddForce(0, 0, Mathf.Lerp(0, 10000, t));
            t += .001f * Time.deltaTime;

        }

        //------------------------------------- REST OF GAME ----------------------------------------------

        if (globalVars.hasTakenOff == true && finishedAnim)
        {


            //------------------------------------------CONTROL MANAGING-----------------------------------------------------------------


            if (isUsingJoyStick)
            {
                moveHorizontal = hValue;
                moveVertical = vValue;


            }

            if (!isUsingJoyStick)
            {
                 moveHorizontal = Input.GetAxis("Horizontal");
                 moveVertical = Input.GetAxis("Vertical");
            }

            float movementH = moveHorizontal * speedH;
            float movementV = moveVertical * speedV;
        
            Vector3 myDeplacement = new Vector3(movementH, movementV, 0f);

            rb.velocity = myDeplacement;
            rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax), 0f);
            rb.rotation = Quaternion.Euler(rb.velocity.y * -tilt/2,0f, rb.velocity.x * -tilt);


        }

    }


    //------------------------------------------COLLISION MANAGING-----------------------------------------------------------------

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rock")
        {
            myWindShield.GetComponent<WindShield>().ChangeWindShield();

            isHit = true;
            Debug.Log("jrentre dans un shit");

        }

      /* if (other.gameObject.tag == "buildings") {
           SpawnPortal();
            Debug.Log("Je rentre dans un building");
        }*/
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Rock")
        {

            isHit = true;

            Debug.Log("le faucon est dans la nuit");

        }

    }

    private void OnTriggerExit(Collider other)
    {
        isHit = false;

        Debug.Log("jsors caliss");

  
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "triggerFracture") FractureBehavior.isFadingIn = true;
    }

    //------------------------------------------OSC  FUNCTIONS-----------------------------------------------------------------


    void hHandler(OscMessage message)
    {
        hValue = message.GetFloat(0);

    }
    void vHandler(OscMessage message)
    {
        vValue = message.GetFloat(0);

    }



    //--------------------------------------------PORTAIL FUNCTION-------------------------------------------------------------


    /*void SpawnPortal() {

        Instantiate(MyPortal, emmitPortal.position, Quaternion.Euler(-90, 0, 0));
      
    }
    */
 

}
