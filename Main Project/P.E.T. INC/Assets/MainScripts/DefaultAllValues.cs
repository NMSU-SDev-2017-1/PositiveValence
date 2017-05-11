//Sets up all the defaults variables
//Last updated by Melissa Duran

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultAllValues : MonoBehaviour {
	public float hunger = 100;
	public float clenliness = 100;
	public float happy = 100;
	public int playtime = 0;
	public int coins = 30;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetFloat ("Hunger", hunger);
		PlayerPrefs.SetFloat ("Cleanliness", clenliness);
		PlayerPrefs.SetFloat ("Happiness", happy);
		PlayerPrefs.SetInt ("Playtime", playtime);
		PlayerPrefs.SetInt ("Coins", coins);
	}

}
