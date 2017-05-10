//Program keeps track of the pet's state of being. Updated in May by Melissa to change the settings 
//to a global so that the health will be kept constants throughout the different scenes.
//Last Edited by Melissa Duran May, 2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetEmotion : MonoBehaviour {

	//Phase 1
	public Sprite happy1;
	public Sprite sad1;
	public Sprite excited1;
	public Sprite angry1;

	//Phase 2
	public Sprite happy2;
	public Sprite sad2;
	public Sprite excited2;
	public Sprite angry2;

	//Phase 3
	public Sprite happy3;
	public Sprite sad3;
	public Sprite excited3;
	public Sprite angry3;

	//Global counters pet's stats
	public float heightHunger;
	public float heightHapiness;
	public float heightCLeanliness;

	//GameObjects of pet's stats
	public GameObject happiness;
	public GameObject hunger;
	public GameObject cleanliness;
	public GameObject time;



	private int phaseLevel = 1;

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}


	//Evolves the characters once the timer gets to a certain time.
	int returnLevel (){
		GlobalTimer getTime = time.GetComponent<GlobalTimer> ();
		if (getTime.playtime <= 5)
			return 1;
		if (getTime.playtime > 5 && getTime.playtime <= 10)
			return 2;
		if (getTime.playtime > 10)
			return 3;
		return 0;
		}

	
	// Update is called once per frame
	void Update () {
		DecreaseStatBar getHunger = hunger.GetComponent<DecreaseStatBar> ();
		DecreaseStatBar getHappiness = happiness.GetComponent<DecreaseStatBar> ();
		DecreaseStatBar getCleanliness = cleanliness.GetComponent<DecreaseStatBar> ();


		phaseLevel = returnLevel ();
			
		if ((getHunger.height + getHappiness.height + getCleanliness.height) / 3 > 75) {
			switch (phaseLevel){
			case 1:
				sr.sprite = excited1;
				break;
			case 2:
				sr.sprite = excited2;
				break;
			case 3:
				sr.sprite = excited3;
				break;
			default: 
				print ("Error");
				break;
			}
		}
		if ((getHunger.height + getHappiness.height + getCleanliness.height) / 3 <= 75 &&(getHunger.height + getHappiness.height + getCleanliness.height) / 3 > 50) {
			switch (phaseLevel){
			case 1:
				sr.sprite = happy1;
				break;
			case 2:
				sr.sprite = happy2;
				break;
			case 3:
				sr.sprite = happy3;
				break;
			default: 
				print ("Error");
				break;
			}
		}
		if ((getHunger.height + getHappiness.height + getCleanliness.height) / 3 <= 50 &&(getHunger.height + getHappiness.height + getCleanliness.height) / 3 > 25) {
			switch (phaseLevel){
			case 1:
				sr.sprite = sad1;
				break;
			case 2:
				sr.sprite = sad2;
				break;
			case 3:
				sr.sprite = sad3;
				break;
			default: 
				print ("Error");
				break;
			}
		}
		if ((getHunger.height + getHappiness.height + getCleanliness.height) / 3 <= 25 &&(getHunger.height + getHappiness.height + getCleanliness.height) / 3 > 0) {
			switch (phaseLevel){
			case 1:
				sr.sprite = angry1;
				break;
			case 2:
				sr.sprite = angry2;
				break;
			case 3:
				sr.sprite = angry3;
				break;
			default: 
				print ("Error");
				break;
			}
		}
			
	}
}
