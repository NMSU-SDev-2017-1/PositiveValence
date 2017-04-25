//Timer used to keep track of how much tme the user has been playing the game
//Last Edited by Melissa Duran April, 2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalTimer : MonoBehaviour {

	//Global time variables
	public  int playtime = 0;
	public  int Playtime;
	private int sec = 0;
	private int min = 0;
	private int hours = 0;
	private int days = 0;
	private int months = 0;
	private int years = 0;
	public Text displayTime;

	public GameObject happiness;
	public GameObject hunger;
	public GameObject cleanliness;





	// Use this for initialization
	void Start () {
		StartCoroutine ("Playtimer");
		setTimeText ();

	}



	//Increments playtime by one second and then calculates the value of the 
	//other time variables based on the value of playtime.
		private IEnumerator Playtimer(){
		DecreaseStatBar getHunger = hunger.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getHappy = happiness.GetComponent<DecreaseStatBar> (); 
		DecreaseStatBar getClean = cleanliness.GetComponent<DecreaseStatBar> (); 
		playtime = PlayerPrefs.GetInt ("Playtime");

		while (getHunger.height != 0 || getHappy.height != 0 ||getHappy.height != 0) {
			playtime = PlayerPrefs.GetInt ("Playtime");
			yield return new WaitForSeconds(1);
			playtime += 1;
			sec = (playtime %60);
			min = (playtime/60) % 60;
			hours = (playtime/3600) % 24;
			days = (playtime/86400) % 30;
			months = (playtime/2592000) % 12;
			years = (playtime/31104000);
			setTimeText ();
			PlayerPrefs.SetInt ("Playtime", playtime);
		}

	}
		

	//Sets the text so that it will be displayed.
	void setTimeText(){
		displayTime.text = years.ToString()+" Years "+ months.ToString()+ " Months " + days.ToString() + " Days " + hours.ToString() + " Hours " + min.ToString() +" Minutes " + sec.ToString() + " Seconds";
	}



}
