using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshGenerator : MonoBehaviour
{
    public Mesh[] mMeshes;

    public GameObject rock;

    private MeshFilter meshFilter;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }


    void LoadRessources()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rock = GetComponent<GameObject>();

        // transform.position = Quaternion.Euler(-90f, 0f, Random.Range(0f, 360f));
        transform.rotation = Quaternion.Euler(-90f, 0f, Random.Range(0f, 360f));
        meshFilter.mesh = mMeshes[(Random.Range(0, mMeshes.Length))];
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y<-7  || gameObject.transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

    }    
        
    }

