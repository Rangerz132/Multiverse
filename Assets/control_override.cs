using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_override : MonoBehaviour
{

    public Animator animator;

    private void Awake()
    {
        playerController.finishedAnim = false;

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        





    }

    public void doneWithAnim()
    {
        playerController.finishedAnim = true;
    }



}
