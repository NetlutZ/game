using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputValue : MonoBehaviour
{
    public CarSteering carSteering;
    public TMP_InputField newVelocity;
    public TMP_InputField newSteerSpeed;
    
    public void InputVelocity(){
        float.TryParse(newVelocity.text,out float result);    //แปลง string to float
        carSteering.moveSpeed = result;
    }

    public void InputSteerSpeed(){
        float.TryParse(newSteerSpeed.text,out float result);    
        carSteering.steerSpeed = result;
    }
}
