using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Transform respawnPoint;
    

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Acid"){
            Player.transform.position = respawnPoint.position;
        }
        
    }
}
