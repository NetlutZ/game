using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputBallMass : MonoBehaviour
{
    public Rigidbody2D BallRb;
    public TMP_InputField newBallMass;

    public void setget(){
        float.TryParse(newBallMass.text,out float result);    //แปลง string to float
        BallRb.mass = result;
    }
}