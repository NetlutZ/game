using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    CarSteering carSteering;
    CheckAnswer checkAnswer;
    
    void Awake(){
        carSteering = FindObjectOfType<CarSteering>();
        checkAnswer = FindObjectOfType<CheckAnswer>();
        checkAnswer.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "UpSpeed"){
            carSteering.moveSpeed += 2;
            Destroy(other.gameObject);
        }

        if(other.tag == "DownSpeed"){
            carSteering.moveSpeed -= 1;
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Question"){
            checkAnswer.gameObject.SetActive(true);
        }
    }
}
