using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindShield : MonoBehaviour
{

    public static int NbrHit = 0;
    public Texture Texture_WindShield_1, Texture_WindShield_2, Texture_WindShield_3, Texture_WindShield_4, Texture_WindShield_5;
    Renderer myTexture;
    // Start is called before the first frame update
    void Start()
    {
        myTexture = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o")) {
            ChangeWindShield();
        }

    }




    public void ChangeWindShield() {

        NbrHit++;

        if (NbrHit == 2) {
            gameObject.GetComponent<Renderer>().material.SetTexture("_WindShieldTextures", Texture_WindShield_1 );
        }
        if (NbrHit == 4) {
            gameObject.GetComponent<Renderer>().material.SetTexture("_WindShieldTextures", Texture_WindShield_2);
        }
        if (NbrHit == 6)
        {
            gameObject.GetComponent<Renderer>().material.SetTexture("_WindShieldTextures", Texture_WindShield_3);
        }
        if (NbrHit == 8)
        {
            gameObject.GetComponent<Renderer>().material.SetTexture("_WindShieldTextures", Texture_WindShield_4);
        }
        if (NbrHit == 10)
        {
            gameObject.GetComponent<Renderer>().material.SetTexture("_WindShieldTextures", Texture_WindShield_5);
        }
        if (NbrHit == 12)
        {
            NbrHit = 0;
        }


        Debug.Log("is trigger");

    }
}
