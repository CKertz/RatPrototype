using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Human", menuName = "Human")]
public class Human : ScriptableObject
{
    public new string name;
    public string description;

    public int health;
    public int attack;
    public int cost;
    public float speed;

    public Sprite humanSprite;
}
