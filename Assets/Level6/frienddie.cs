using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class frienddie : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneName;

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Friend")){
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
