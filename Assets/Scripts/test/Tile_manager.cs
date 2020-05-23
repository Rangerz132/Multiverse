using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_manager : MonoBehaviour
{

    public GameObject[] tilePrefabs;

    public float tileLength = 18.6f;

    public Vector3 tileScale = new Vector3(1f, 1f, 1f);

    private float distanceTravelled = 0f;

    public static float BLOCK_SPEED = 7f;

    public static float TILE_MAX_DISTANCE = 300f;

    public static float OBSTACLE_PROP = .45f;

    public float speedTranslate = 7f;

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
        BLOCK_SPEED = speedTranslate;

        if (distanceTravelled >= tileLength)
        {
            distanceTravelled = 0f;

            SpawnTile();
        }
        else {
            distanceTravelled += Time.deltaTime * BLOCK_SPEED;
        }
    }

    private void SpawnTile(int prefabIndex = 0)
    {
        GameObject go;
        go = Instantiate(tilePrefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = tileScale;
    }
}
