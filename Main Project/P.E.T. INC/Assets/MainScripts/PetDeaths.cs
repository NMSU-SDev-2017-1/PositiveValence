using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetDeaths : MonoBehaviour {

	//Phase1
	public Sprite burn1;
	public Sprite choke1;
	public Sprite depressed1;
	public Sprite drown1;
	public Sprite electrocute1;
	public Sprite poison1;
	public Sprite starve1;

	//Phase2
	public Sprite burn2;
	public Sprite choke2;
	public Sprite depressed2;
	public Sprite drown2;
	public Sprite electrocute2;
	public Sprite poison2;
	public Sprite starve2;


	//Phase3
	public Sprite burn3;
	public Sprite choke3;
	public Sprite depressed3;
	public Sprite drown3;
	public Sprite electrocute3;
	public Sprite poison3;
	public Sprite starve3;




	public GameObject happiness;
	public GameObject hunger;
	public GameObject cleanliness;
	public GameObject time;

	private float scale;
	private int phaseLevel = 1;
	SpriteRenderer sr;




	//Let's the script know in which stage the pet should be in
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






	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> (); 
		scale = 0.2f;
	}
	
	// Update is called once per frame
	void Update () {
		DecreaseStatBar getHunger = hunger.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getHappy = happiness.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getClean = cleanliness.GetComponent<DecreaseStatBar> (); 
		phaseLevel = returnLevel ();

		if (getHunger.height == 0) {
			PetMovement.checkPulse.dead = true;
			getHappy.height = 0;
			getClean.height = 0; 

			//Change srpite
			switch (phaseLevel){
			case 1:
				sr.sprite = starve1;
				break;

			case 2:
				sr.sprite = starve2;
				break;

			case 3:
				sr.sprite = starve3;
				break;
			}

			transform.localScale = new Vector3(scale, scale, scale);  
		}
		if (getHappy.height == 0) {
			PetMovement.checkPulse.dead = true; 


			//Change srpite
			switch (phaseLevel) {
			case 1:
				sr.sprite = depressed1;
				break;

			case 2:
				sr.sprite = depressed2;
				break;

			case 3:
				sr.sprite = depressed3;
				break;

			}
			
			transform.localScale = new Vector3(scale, scale, scale);  
		}


		if (getClean.height == 0) {
			PetMovement.checkPulse.dead = true; 
			getHappy.height = 0;
			getHunger.height = 0; 

			//Change srpite
			switch (phaseLevel) {
			case 1:
				sr.sprite = poison1;	
				break;
			case 2:
				sr.sprite = poison2;	
				break;
			case 3:
				sr.sprite = poison3;	
				break;
			}
			transform.localScale = new Vector3(scale, scale, scale);  
		}

	}
}
