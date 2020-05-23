using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_tile_random : MonoBehaviour
{

    private float distanceTravelled2 = 0f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Tile_manager_random.BLOCK_SPEED2 * Time.deltaTime);
        distanceTravelled2 += Tile_manager_random.BLOCK_SPEED2 * Time.deltaTime;

        if (distanceTravelled2 > Tile_manager_random.TILE_MAX_DISTANCE2) {
            Destroy(gameObject);
        }
    }
}
