using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		velocity = new Vector2 (Random.Range (MinVelocity.x, MaxVelocity.x), Random.Range (MinVelocity.y, MaxVelocity.y));
	}


	public float LifeSpan = 2f;
	float TimeAlive = 0;
	 
	Vector2 velocity;
	public Vector2 MaxVelocity = new Vector2 (-.01f, 0.05f);
	public Vector2 MinVelocity = new Vector2 (0.01f,0.025f);


	// Update is called once per frame. Destroys fire after some time and translate each fire after.
	void Update () {
		TimeAlive -= Time.deltaTime;
		if (TimeAlive >= LifeSpan) {
			Destroy (gameObject);
			return;
		}
		this.transform.Translate (velocity*Time.deltaTime);
	}
}
