using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_generator : MonoBehaviour
{

    public GameObject[] stones;
    public GameObject player;
    public Vector3 spawnValues;
    public float spawnWait;
    public bool useY = true;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stopSpawning;
    public bool followPlayer=false;
    private int randStone;

    public float speed;



    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            spawnValues.x = player.transform.position.x;
        }

        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator Spawner() {
        yield return new WaitForSeconds(startWait);

        while (!stopSpawning) {
            randStone = Random.Range(0, 9);
            Vector3 spawnPosition;

            if (followPlayer)
            {
                 spawnPosition = new Vector3(Random.Range(spawnValues.x-10,spawnValues.x+10), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));

            }
            else
            {
                 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));

            }

            Instantiate(stones[randStone], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
