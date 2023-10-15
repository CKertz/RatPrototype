using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatUnitController : MonoBehaviour
{
    public Rat rat;

    // Start is called before the first frame update
    void Start()
    {
        var renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = rat.ratSprite;
        Debug.Log(rat.description);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
