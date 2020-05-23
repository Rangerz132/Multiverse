using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVars : MonoBehaviour

  
{
    public static bool wentThrough = false;
    public static bool hasTakenOff = false;
    public static int levelUp;
    public static Vector3 ShipPosition;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKey("l"))
        {
            hasTakenOff = !hasTakenOff;
        }
        if (levelUp == 5)
        {
            levelUp = 0;
        }
    }
}
