using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Dist : MonoBehaviour
{

    bool animationStart = false;
    public float MaxHeight;
    public float degreeLerp;
    

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 endPos = new Vector3(transform.position.x, 50f, transform.position.z);

        DetectDistance();

        if (transform.position.y >= MaxHeight)
        {
            animationStart = false;

        }

        if (animationStart == true) {
            

            //Translate top with a smooth lerp effect
            transform.position = Vector3.Lerp(transform.position, endPos, degreeLerp * Time.deltaTime);

        }

      
    }

    void DetectDistance() {
        

        if (transform.position.z <= 200) {

            animationStart = true;
           
        }
    }

}
