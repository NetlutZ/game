using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using UnityEngine.SceneManagement;

public class CheckAns : MonoBehaviour
{
    float playerAnswer = 0.000f;
    float Answer;
    float us = 0.3f;
    float W = 480;
    float N;
    float P;
    float F;
    float AB = 0.6f;
    float M1;
    float M2;
    private Rigidbody2D r;
    private Rigidbody2D girl;
    private Rigidbody2D m;
    private Vector2 startPosition;
    float force;    
    TMP_InputField inputFieldUser;
    TextMeshProUGUI textResult;
    Text textH;
    Text textBr;
    public Vector2 tempPosition;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        inputFieldUser = gameObject.transform.Find("InputFieldUser").GetComponent<TMP_InputField>();
        textResult = gameObject.transform.Find("TextResult").GetComponent<TextMeshProUGUI>();
        textH = gameObject.transform.Find("TextH").GetComponent<Text>();
        textBr = gameObject.transform.Find("TextBr").GetComponent<Text>();
	    r = gameObject.transform.Find("DoorLocked").GetComponent<Rigidbody2D>();
        m = gameObject.transform.Find("DoorUnlocked3").GetComponent<Rigidbody2D>(); 
        m.gameObject.SetActive(false);
        girl = gameObject.transform.Find("win_01").GetComponent<Rigidbody2D>(); 
        girl.gameObject.SetActive(false);
        //Newton's Laws
        N=W;
        F = N*us;
        P = F;
        //Moment
        Answer = W*(AB/2)/P;

		
    }

    // Update is called once per frame
    public void SubmitClick()
    {
        playerAnswer = float.Parse(inputFieldUser.text,CultureInfo.InvariantCulture);
        // textH.text = "";
        // textBr.text = "";
        textH.gameObject.SetActive(false);
        textBr.gameObject.SetActive(false);
        if(playerAnswer == Answer){
            textResult.text = "You are correct!";
            // ChangeOb(r,l);
            r.gameObject.SetActive(false);
            m.gameObject.SetActive(true);
            girl.gameObject.SetActive(true);
            Invoke("FinScene",2f);
            
        }
        else{
            textResult.text = "You are Wrong, plese try again";
            r.AddForce(new Vector2(10000,0));
        }
    }
    void FinScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    // void ChangeOb(Rigidbody2D r,Rigidbody2D l)
    // {
    //     tempPosition = l.transform.position;
    //     l.transform.position = r.transform.position;
    //     r.transform.position = tempPosition;
    // }
}
