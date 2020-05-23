using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_tile : MonoBehaviour
{

    private float distanceTravelled = 0f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Tile_manager.BLOCK_SPEED * Time.deltaTime);
        distanceTravelled += Tile_manager.BLOCK_SPEED * Time.deltaTime;

        if (distanceTravelled > Tile_manager.TILE_MAX_DISTANCE) {
            Destroy(gameObject);
        }
    }
}
