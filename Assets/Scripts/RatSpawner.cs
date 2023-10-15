using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatSpawner : MonoBehaviour
{
    public GameObject ratUnitPrefab;
    public int ratUnitInitialCount = 100;

    // Start is called before the first frame update
    void Start()
    {
        //for (int j = 0; j < ratUnitInitialCount; j++)
        //{
            Instantiate(ratUnitPrefab);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
