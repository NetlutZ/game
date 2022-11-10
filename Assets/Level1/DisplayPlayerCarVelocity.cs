using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayPlayerCarVelocity : MonoBehaviour
{
    public Rigidbody2D playerCarRb;
    [SerializeField] TextMeshProUGUI playerCarVelocityText;
    CarSteering carSteering;

    void Awake(){
        carSteering = FindObjectOfType<CarSteering>();
    }

    void Update()
    {
        playerCarVelocityText.text = gameObject.name + " Velocity : " + carSteering.moveSpeed;
    }
}
