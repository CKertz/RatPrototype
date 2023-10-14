using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    public GameObject humanUnitPrefab;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHuman", 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnHuman()
    {
        Instantiate(humanUnitPrefab);
    }
}
