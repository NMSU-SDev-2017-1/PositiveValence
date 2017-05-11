using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMovement : MonoBehaviour {

	public int speed;
	public static PetMovement checkPulse;
	public bool dead;
	public Transform destination;
	public Rigidbody2D rb;
	public GameObject[] recent = new GameObject[10]; 
	public GameObject[] gos; 

	private int rotate;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();  
		checkPulse = this;
		dead = false;
		rotate = 0;
	}
	
	// Update is called once per frame
	void Update () {

		gos = GameObject.FindGameObjectsWithTag("Object");

		destination = findClosestObject (gos).transform;
		float step = speed* 0.01f;  

		if (dead != true) {
			transform.position =Vector2.MoveTowards(transform.position, destination.position, step ) ;       
		} else {
			RotateOnDeath ();
		}
			
	}

	void OnCollisionEnter2D(Collision2D col){
		for (int i = 9; i != 0; i--) {
			recent [i - 1] = recent [i];
		}
		recent [0] = col.gameObject; 
		col.gameObject.tag = "Used"; 
	}

	GameObject findClosestObject(GameObject[] gos ) {
		GameObject closest = null;
		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			Vector3 diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				closest = go;
				distance = curDistance;
			}
		}
		return closest;
	}

	void RotateOnDeath (){
		if (rotate == 0) {
			transform.Rotate (Vector3.forward * -90);
			rotate = 1;
			return; 
		}
		return;
	}
}
