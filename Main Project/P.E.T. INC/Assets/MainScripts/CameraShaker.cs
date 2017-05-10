//Last Edited by Melissa Duran, 4/30/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour {


	public Camera mainCam;//Camera that will be shaked
	float shakeAmount = 0;//Amount the camera will be shaked

	//If the mainCam is not defined it sets it to the main camera
	void Awake(){
		if (mainCam == null)
			mainCam = Camera.main;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.T))
			Shake (0.1f, 0.2f);
	}

	//Moderates the shaking
	public void Shake (float amt, float length){
		shakeAmount = amt;
		InvokeRepeating ("BeginShake", 0, 0.01f); 
		Invoke ("StopShake", length);
	}


	//Starts shaking
	void BeginShake(){
		if (shakeAmount > 0) {
			Vector3 camPos = mainCam.transform.position;
			float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
			float offsetY = Random.value * shakeAmount * 2 - shakeAmount;
			camPos.x += offsetX;
			camPos.y += offsetY;

			mainCam.transform.position = camPos;
		}
	}


	//Ends shaking
	void StopShake(){
		CancelInvoke ("StopShake");
		mainCam.transform.localPosition = Vector3.zero;
	}
}
