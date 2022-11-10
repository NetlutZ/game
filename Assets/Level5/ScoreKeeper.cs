using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswer;
    int questionsSeen;

    public int GetCorrectAnswer(){
        return correctAnswer;
    }

    public void InCrementCorrectAnswers(){
        correctAnswer++;
    }

    public int GetQuestionSeen(){
        return questionsSeen;
    }

    public void IncrementQuestionsSeen(){
        questionsSeen++;
    }

    public int CalculateScore(){
        return Mathf.RoundToInt(correctAnswer / (float)questionsSeen * 100);
    }
}
