using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetEvolution : MonoBehaviour {

	public Sprite phase1;
	public Sprite phase2;
	public Sprite phase3;
	private int time;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame. We will check if pet needs to be evolved here.
	/*void Update () {
		switch (time = GlobalTimer.getTime()){

		case 5:
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = phase1;
			break;
		case 10:
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = phase2;
			break;
		case 15:
			this.gameObject.GetComponent<SpriteRenderer> ().sprite = phase3;
			break;
		}
	}*/
}
