using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new question here";
    [SerializeField] Sprite QuestionImage;                                                  
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;    //ตำแหน่ง choice ที่ถูกต้อง
    [SerializeField] Sprite solutionImage;                                               
    [SerializeField] Sprite sol;                                                    

    public Sprite GetQuestionImage(){                                               
        return QuestionImage;
    }
    public string GetQuestion(){
        return question;
    }

    public string GetAnswer(int index){
        return answers[index];
    }

    public int GetCorrectAnswerIndex(){
        return correctAnswerIndex;
    }

    public Sprite GetSolImage(){                                                    
        return solutionImage;
    }

    public Sprite GetSol(){                                                         
        return sol;
    }
}
