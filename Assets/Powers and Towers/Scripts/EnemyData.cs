﻿using System;
using UnityEngine;
/// <summary>
/// Determens what enemy it is. | What Type of enemy.
/// </summary>
[CreateAssetMenu(fileName ="new Enemy Data",menuName = "ScriptableObject/Enemies/new Enemy")]
[Serializable]
public class EnemyData : ScriptableObject
{
    public string _name = "N/A";
    // Stats
    public int health = 10;
    public int lootValue = 1;
    public float speed = 1f;
    //
    public int EnemyID = -1;
    // Shape
    public Sprite spriteImage;
    public Vector3 Scale = new Vector3(0.5f,0.5f,1f);
    public AnimationClip movingAnimation;
    public GameObject gameObject;
    // 
    public DamageType[] resistances;
    public DamageType[] weakness;

}