﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour {
	public GameObject currentObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		

	}


	void OnTriggerEnter2D(Collider2D other){

		Destroy (other.gameObject);
		
	}

}
