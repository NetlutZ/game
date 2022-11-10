using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 2;

    void Awake() {
        speed = Random.Range(10,20);
    }

    public void Update() {
        transform.Translate(0,speed*Time.deltaTime,0);
    }
}
