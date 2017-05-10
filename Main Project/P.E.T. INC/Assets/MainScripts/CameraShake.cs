using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {


	public float shakeTimer; //amount of time the shake will last
	public float shakeAmount; //intensity of the shake


	//Will shake the camera when spacebar is pressed.
	void update(){
		
		if(Input.GetButton("Jump")){
			ShakeCamera (0.1f,5);
		}

		if (shakeTimer >= 0) {
			Vector2 shakePos = Random.insideUnitCircle*shakeAmount; 
			transform.position = new Vector3 (transform.position.x + shakePos.x, transform.position.y + shakePos.y, transform.position.z);
			shakeTimer -= Time.deltaTime;
		}


	}

	//Sets values for shakeamount and shaketimer
	public void ShakeCamera(float shakePower, float shakeDuration){
		shakeAmount = shakePower;
		shakeTimer = shakeDuration;
		
	}








}
