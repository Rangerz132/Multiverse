
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Infinite_world_manager : MonoBehaviour
{

    public GameObject[] worldPrefab;
    public float spawnX= -250f;
    public float spawnY = -110f;
    public float spawnZ = 0f;
    public float worldLength;
    public int nbrWorldOnScreen;
    public float maxZ = -500f;
    private int lastPrefabIndex = 0;
    private List<GameObject> activeWorldPrefabs;
 

    void Start()
    {
        activeWorldPrefabs = new List<GameObject>();


       for (int i = 0; i < nbrWorldOnScreen; i++) {
          SpawnWorld();
        }  
    }

    void Update()
    {

        Debug.Log(worldLength);
       if (activeWorldPrefabs[0].transform.position.z < maxZ) {
            SpawnWorld();
            DeleteWorldPrefab();
       }

      
    }

    private void SpawnWorld(int prefabIndex = -1) {
        GameObject instancingWorld;
        instancingWorld = Instantiate(worldPrefab[0]) as GameObject;

        instancingWorld = Instantiate(worldPrefab[RandomPrefabIndex()]) as GameObject;
        instancingWorld.transform.SetParent(transform);
        instancingWorld.transform.position = new Vector3(spawnX, spawnY, spawnZ);
        
        spawnZ += worldLength;
        activeWorldPrefabs.Add(instancingWorld);
    }

    private void DeleteWorldPrefab() {
        Destroy(activeWorldPrefabs[0]);
        activeWorldPrefabs.RemoveAt(0);

    }

    private int RandomPrefabIndex() {
        if (worldPrefab.Length <= 1) {
            return 0;
        }

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex) {
            randomIndex = Random.Range(0, worldPrefab.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;

    }

    
}
