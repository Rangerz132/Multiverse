using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class lavaLevel : MonoBehaviour
{
    public GameObject wall;
    public GameObject rockGenerator;

    // Start is called before the first frame update
    private void Awake()
    {
        rockGenerator.GetComponent<Stone_generator>().enabled = false;

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish") {
            faceSmokeBehavior.isFading = true;
            rockGenerator.GetComponent<Stone_generator>().enabled = true;


        }

        if (other.gameObject.tag == "lavaRocks")
        {
            if (other.gameObject.GetComponent<MeshFilter>().sharedMesh.name == "rock_00")
            {
                other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                other.gameObject.GetComponent<Rigidbody>().AddForce((Vector3.down * 10000) * other.gameObject.transform.position.y * 10);
            }



            else
            {
                other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                other.gameObject.GetComponent<Rigidbody>().AddForce((Vector3.down * 10000) * other.gameObject.transform.position.y * 5);
            }
      



           // Destroy(other.gameObject);
        }


    }




    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            faceSmokeBehavior.isFading = false;
            Destroy(wall);

        }
    }

}
