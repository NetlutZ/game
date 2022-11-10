using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainTheory : MonoBehaviour
{
    NullLevel nullLevel;
    bool isExplain;

    void Awake(){
        nullLevel = FindObjectOfType<NullLevel>();
        nullLevel.gameObject.SetActive(false);
    }

    public void isClick(){
        if(isExplain == true){
            nullLevel.gameObject.SetActive(false);
            isExplain = false;
        }
        else{
            nullLevel.gameObject.SetActive(true);
            isExplain = true;
        }        
    }
}
