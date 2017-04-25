using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour {

	public GameObject statEffected;
	public float effectAmount;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col){

		if (col.collider.gameObject.name == "Pet1") {
			DecreaseStatBar statbar = statEffected.GetComponent<DecreaseStatBar> ();

			statbar.height += effectAmount;
		}
	}
}
