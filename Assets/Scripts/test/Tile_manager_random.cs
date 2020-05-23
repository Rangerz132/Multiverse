using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_manager_random : MonoBehaviour
{

    public GameObject[] tilePrefabs2;

    public float tileLength2 = 18.6f;

    public Vector3 tileScale2 = new Vector3(1f, 1f, 1f);

    private float distanceTravelled2 = 0f;

    public static float BLOCK_SPEED2 = 7f;

    public static float TILE_MAX_DISTANCE2 = 300f;

    public static float OBSTACLE_PROP2 = .45f;

    public float speedTranslate2 = 7f;

    public float tileMaxDistanceR = 300f;

    private int randomIndex;

    // Start is called before the first frame update
    private void Awake()
    {

    }

    void Start()
    {
        SpawnTile();

       
    }

    // Update is called once per frame
    void Update()
    {
        BLOCK_SPEED2 = speedTranslate2;

        TILE_MAX_DISTANCE2 = tileMaxDistanceR;

        randomIndex = Random.Range(0, tilePrefabs2.Length);

        if (distanceTravelled2 >= tileLength2)
        {
            distanceTravelled2 = 0f;

            SpawnTile();
        }
        else {
            distanceTravelled2 += Time.deltaTime * BLOCK_SPEED2;
        }
    }

    private void SpawnTile()
    {
        GameObject go;
        go = Instantiate(tilePrefabs2[randomIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = tileScale2;

    
    }

}
