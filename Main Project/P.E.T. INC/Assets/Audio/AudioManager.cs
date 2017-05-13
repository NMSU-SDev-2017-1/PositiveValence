/*Starts a selected music clip. 
Las edited by Melissa Duran 5/2017*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioSource BGM;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);//Prevents 
		
	}

	public void ChangeBGM(AudioClip music){
		BGM.Stop ();
		BGM.clip = music;
		BGM.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
