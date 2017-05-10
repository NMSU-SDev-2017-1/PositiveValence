using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDeaths : MonoBehaviour {

	public Sprite burn;
	public Sprite choke;
	public Sprite depressed;
	public Sprite drown;
	public Sprite electrocute;
	public Sprite poison;
	public Sprite starve;

	public GameObject happiness;
	public GameObject hunger;
	public GameObject cleanliness;

	private float scale;

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> (); 
		scale = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		DecreaseStatBar getHunger = hunger.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getHappy = happiness.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getClean = cleanliness.GetComponent<DecreaseStatBar> (); 

		if (getHunger.height == 0) {
			PetMovement.checkPulse.dead = true;
			getHappy.height = 0;
			getClean.height = 0; 
			sr.sprite = starve;
			transform.localScale = new Vector3(scale, scale, scale);  
		}
		if (getHappy.height == 0) {
			PetMovement.checkPulse.dead = true; 
			getHunger.height = 0;
			getClean.height = 0; 
			sr.sprite = depressed;
			transform.localScale = new Vector3(scale, scale, scale);  
		}
		if (getClean.height == 0) {
			PetMovement.checkPulse.dead = true; 
			getHappy.height = 0;
			getHunger.height = 0; 
			sr.sprite = poison;	
			transform.localScale = new Vector3(scale, scale, scale);  
		}

	}
}
