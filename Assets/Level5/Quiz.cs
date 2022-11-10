using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    [Header("Questions")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] List<QuestionSO> questions = new List<QuestionSO>();
    [SerializeField] Image questionImage;                                               
    [SerializeField] Image solImage;                                                    
    [SerializeField] Image sol;                                                         
    QuestionSO currentQuestion;

    [Header("Answers")]
    [SerializeField] GameObject[] AnswerButton;
    int correctAnswerIndex;
    bool hasAnsweredEarly = true;

    [Header("Button Colors")]
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    [Header("Timer")]
    [SerializeField] Image timerImage;
    Timer timer;

    [Header("Scoring")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    [Header("ProgressBar")]
    [SerializeField] Slider progressBar;

    public bool isComplete;

    void Awake(){
        timer = FindObjectOfType<Timer>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        progressBar.maxValue = questions.Count;
        progressBar.value = 0;
    }

    void Update(){
        timerImage.fillAmount = timer.fillFraction;
        if(timer.loadNextQuestion){
            if(progressBar.value == progressBar.maxValue){
                isComplete = true;
                return;
            }
            hasAnsweredEarly = false;
            GetNextQuestion();
            timer.loadNextQuestion = false;
        }
        else if(!hasAnsweredEarly && !timer.isAnsweringQuestion){
            DisplayAnswer(-1);
            SetButtonState(false);
        }
    }

    public void OnAnswerSelected(int index){
        hasAnsweredEarly = true;
        DisplayAnswer(index);
        SetButtonState(false);      //ปิด interactable ของ button
        timer.CancelTimer();
        scoreText.text = "Score : " + scoreKeeper.CalculateScore() + "%";
    }

    void DisplayAnswer(int index){
        Image buttonImage;
        if(index == currentQuestion.GetCorrectAnswerIndex()){
            questionText.text = "Correct";
            buttonImage = AnswerButton[index].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
            scoreKeeper.InCrementCorrectAnswers();
        }
        else{
            correctAnswerIndex = currentQuestion.GetCorrectAnswerIndex();
            string correctAnswer = currentQuestion.GetAnswer(correctAnswerIndex);
            questionText.text = "Sorry the correct answer was " + correctAnswer;
            buttonImage = AnswerButton[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        solImage.sprite = currentQuestion.GetSolImage();                                            //
    }

    void GetNextQuestion(){
        if(questions.Count > 0){
            SetButtonState(true);
            SetDefaultButtonSprites();
            GetRandomQuestion();
            DisplayQuestion();
            progressBar.value++;                        //เพิ่ม progressbar
            scoreKeeper.IncrementQuestionsSeen();
        }
    }

    void GetRandomQuestion(){
        int index = Random.Range(0,questions.Count);
        currentQuestion = questions[index];

        if(questions.Contains(currentQuestion)){
            questions.Remove(currentQuestion);
        }
    }

    void DisplayQuestion(){
        questionText.text = currentQuestion.GetQuestion();

        for(int i=0;i<AnswerButton.Length;i++){
            TextMeshProUGUI buttonText = AnswerButton[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = currentQuestion.GetAnswer(i);
        }
        questionImage.sprite = currentQuestion.GetQuestionImage();                          
        solImage.sprite = currentQuestion.GetSol();                                         
    }

    void SetButtonState(bool state){
        for(int i=0;i<AnswerButton.Length;i++){
            Button button = AnswerButton[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    void SetDefaultButtonSprites(){
        for(int i=0;i<AnswerButton.Length;i++){
            Image buttonImage = AnswerButton[i].GetComponent<Image>();
            buttonImage.sprite = defaultAnswerSprite;
        }
    }
}
