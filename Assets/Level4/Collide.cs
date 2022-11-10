using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Stone"){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}