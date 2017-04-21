using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

	public int playtime = 0;
	private int days = 0;
	private int hours = 0;
	private int min = 0;
	private int sec = 0;
	private bool buttonPressed = false;


	void Start () {
		StartCoroutine ("Timer");	
	}

	private IEnumerator Timer(){
		while (true) {
			yield return new WaitForSeconds (1);
			playtime = playtime + 1;
			sec = (playtime % 60);
			min = (playtime / 60) % 60;
			hours = (playtime / 3600) % 24;
			days = (playtime / 86400) % 365;
		}//End while
	}//End IEnumerator




	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect(30, 30, 40, 40), "Time"))
			if (buttonPressed)
				buttonPressed = false;
			else
				buttonPressed = true;
		
		if (buttonPressed)	
			GUI.Label (new Rect(80,30,400,50), "Time = " + days.ToString() + " Days "  + hours.ToString() + " Hours " + min.ToString() + " Minutes "+ sec.ToString() + " Seconds ");
	}
}
