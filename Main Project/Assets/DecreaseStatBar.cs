using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DecreaseStatBar : MonoBehaviour {

	public static DecreaseStatBar instance;
	public float height;
	public int speed;
	private int frames = 1;

	// Use this for initialization
	void Start () {
		instance = this;
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
		

	}
}
