using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CheckAnswer : MonoBehaviour
{
    public TMP_InputField velocityRelative;
    public TMP_InputField centripetalForce;
    [SerializeField] GameObject questionBlock;
    AutoMove autoMove;
    CarSteering carSteering;

    void Awake(){
        autoMove = FindObjectOfType<AutoMove>();
        carSteering = FindObjectOfType<CarSteering>();
    }

    public void getVelocityRelative(){
        int.TryParse(velocityRelative.text,out int result);
        if(result == carSteering.moveSpeed - autoMove.speed){
            Destroy(questionBlock);
        }
    }

    public void getCentripetalForce(){
        int.TryParse(centripetalForce.text,out int result);
        Debug.Log(1000*carSteering.moveSpeed*carSteering.moveSpeed);
        if(result == 1000*carSteering.moveSpeed*carSteering.moveSpeed){
            Debug.Log("Ture");
            Destroy(questionBlock);
        }
    }
}

