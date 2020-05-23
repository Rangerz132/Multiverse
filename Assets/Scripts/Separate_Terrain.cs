using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Separate_Terrain : MonoBehaviour
{

    public float speedMoveX = 2f;
    public bool alreadyMove = false;
    private Vector3 posTemp;
    public float posI = 0f;
    public float timeLeft = 30.0f;

    

    void Start()
    {
        
    }

    
    void Update()
    {

        if (Input.GetKey(KeyCode.F) && alreadyMove == false)
        {
            SeparateWorld();
        }

        if (Input.GetKey(KeyCode.R) && alreadyMove == true)
        {
            ReplaceWorld();
        }

    }


    private void SeparateWorld() {

        posI++;

        if (posI <= 100f)
        {
            transform.Translate(speedMoveX * Time.deltaTime, 0f, 0f);
        }

        if (posI >= 100f)
        {

            alreadyMove = true;
            posI = 100f;
        }

    }


    private void ReplaceWorld() {
        posI--;

        if (posI <= 101)
        {
            transform.Translate(-speedMoveX * Time.deltaTime, 0f, 0f);
        }

        if (posI <= 1)
        {

            alreadyMove = false;
            posI = 1;
        }

    }

}
