using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class HumanUnitController : MonoBehaviour
{
    public Human human;

    void Start()
    {
        var renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = human.humanSprite;
        Debug.Log(human.description);
    }

}
