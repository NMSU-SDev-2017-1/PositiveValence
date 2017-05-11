using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicOnLoad : MonoBehaviour {

	public AudioClip newTrack;
	private AudioManager theAM;

	// Use this for initialization
	void Start () {
		theAM = FindObjectOfType<AudioManager> ();
		theAM.ChangeBGM (newTrack);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
