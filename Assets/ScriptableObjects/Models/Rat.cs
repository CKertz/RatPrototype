using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rat", menuName = "Rat")]
public class Rat : ScriptableObject
{
    public new string name;
    public string description;

    public int health;
    public int attack;
    public int cost;
    public float speed;

    public Sprite ratSprite;
}
