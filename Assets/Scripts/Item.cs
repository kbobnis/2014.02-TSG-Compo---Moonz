﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public string _name;
	public Texture texture;

	const string SLOT_UP = "up";
	const string SLOT_DOWN = "down";
	const string SLOT_LEFT = "left";
	const string SLOT_RIGHT = "right";

	public string slotName;

	public float maxDist;
	public float angle;
	public float damage;
	public bool dualHand;
	public float cooldown;

	public float shieldValue;
	public float shieldRestoreTime;
	public float speedChange;

    public GameObject missilePrefab;

    void Start () {
    
    }
    
    void Update () {
    
    }
}