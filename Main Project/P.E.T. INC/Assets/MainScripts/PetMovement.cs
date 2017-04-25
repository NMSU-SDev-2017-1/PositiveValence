using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetMovement : MonoBehaviour {

	public int speed;
	public static PetMovement checkPulse;
	public bool dead;

	private int rotate;

	// Use this for initialization
	void Start () {
		checkPulse = this;
		dead = false;
		rotate = 0;
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 destination = findClosestObject ().transform.position;
		Vector2 posNow = transform.position;

		if (dead != true) { 
			if (Mathf.Abs (posNow.x) - Mathf.Abs (destination.x) != 0) {
				if (posNow.x - destination.x >= 0) {
					transform.Translate (Vector2.left * Time.deltaTime * speed);
				} else {
					transform.Translate (Vector2.right * Time.deltaTime * speed);
				}
			} else {
				transform.Translate (Vector2.zero * Time.deltaTime * 0);
			}
		} else {
			RotateOnDeath ();
		}
			
	}

	GameObject findClosestObject() {
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Object");
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
