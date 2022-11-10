using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayVelocity : MonoBehaviour
{
    public Rigidbody2D ballRb;
    [SerializeField] TextMeshProUGUI velocityText;
    public float v;

    void Update()
    {
        v = Mathf.Sqrt(Mathf.Pow(ballRb.velocity.x,2)+Mathf.Pow(ballRb.velocity.y,2));
        velocityText.text = gameObject.name + " Velocity : " + v.ToString("F2") + ", Mass : " + ballRb.mass; 
    }
}