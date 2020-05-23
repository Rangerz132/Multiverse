using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_generator : MonoBehaviour
{
    public GameObject[] towers;
    private GameObject myShip;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stopSpawning;
    public int towersStone;
 



    // Start is called before the first frame update
    void Start()
    {
       
        myShip = GameObject.Find("Ship");
        StartCoroutine(Spawner());

        
    }

    // Update is called once per frame
    void Update()
    {

        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        


    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stopSpawning)
        {
            towersStone = Random.Range(0, 2);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(towers[towersStone], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }


   
}

