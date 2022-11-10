using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayYellowCarVelocity : MonoBehaviour
{
    public Rigidbody2D yellowCarRb;
    [SerializeField] TextMeshProUGUI yellowCarVelocityText;
    AutoMove autoMove;

    void Awake(){
        autoMove = FindObjectOfType<AutoMove>();
    }

    void Update()
    {
        yellowCarVelocityText.text = gameObject.name + " Velocity : " + autoMove.speed;
    }
}
