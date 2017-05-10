using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DecreaseStatBar : MonoBehaviour {

	public static DecreaseStatBar instance;
	public float height;
	public int speed;
	private int frames = 1;
	public int whatBarAmI = 0; // set to 1 for hunger, 2 for clenliness, 3 for happiness
	// Use this for initialization
	void Start () {
		instance = this;
		switch(whatBarAmI){
		case 1:
			height = PlayerPrefs.GetFloat ("Hunger");
			break;

		case 2:
			height = PlayerPrefs.GetFloat ("Cleanliness");
			break;
		case 3:
			height = PlayerPrefs.GetFloat ("Happiness");
			break;
		}



	}
	
	// Update is called once per frame
	void Update () {



		GameObject bar = GameObject.Find(gameObject.name);
		var barHeightTransform = bar.transform as RectTransform;
		barHeightTransform.sizeDelta = new Vector2 (20, height);
		//transform.Translate(Vector2.down*Time.deltaTime*(speed/2));

		if (height != 0) {

			if (frames % speed == 1) {
				height--;
			}
			if (height > 100) {
				height = 100;
			}
		}
		frames++;
		switch(whatBarAmI){
		case 1:
			PlayerPrefs.SetFloat ("Hunger", height);
		break;

		case 2:
			PlayerPrefs.SetFloat ("Cleanliness", height);
			break;
		case 3:
			PlayerPrefs.SetFloat ("Happiness", height);
			break;
		}
	}
}
