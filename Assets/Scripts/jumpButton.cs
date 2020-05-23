using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class jumpButton : MonoBehaviour
{
   public Animator animator;
    private int levelToLoad;
    public static int currentlevel;
    // Update is called once per frame
    void Update()
    {
        if (playerController.isFastEnough == true)
        {

            FadeToLevel(globalVars.levelUp);

        }

       
        
    }

    public void FadeToLevel(int levelIndex)
    {


        levelToLoad = levelIndex;
        currentlevel = levelToLoad;
        animator.SetTrigger("Fade out");


       
    }
    public void OnFadeComplete()
    {
        globalVars.levelUp++;

        SceneManager.LoadScene(globalVars.levelUp);
        playerController.isFastEnough = false;
        globalVars.hasTakenOff = true;

    }
}
