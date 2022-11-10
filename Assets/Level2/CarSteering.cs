using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSteering : MonoBehaviour {
	[SerializeField] public float moveSpeed = 10f;
	[SerializeField] public float steerSpeed = 5f;
	void Update(){
		float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;	//move ซ้ายขวา
		float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;		//move  หน้าหลัง
		transform.Rotate(0,0,-steerAmount);
		transform.Translate(0,moveAmount,0);
	}

}


