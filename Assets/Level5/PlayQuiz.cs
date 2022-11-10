using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayQuiz : MonoBehaviour
{
    public bool isClick;

    public void ClickPlayQuiz(){
        isClick = true;
    }

    void Update(){
        Debug.Log(isClick);
    }

    public void DestroyMonitor(GameObject thing){
        Destroy(thing);
    }
}
