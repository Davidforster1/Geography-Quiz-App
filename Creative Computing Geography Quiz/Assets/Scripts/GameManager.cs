// the following game logic code is based on a YouTube tutorial which can be found here: https://www.youtube.com/watch?v=g_Ff1SPhidg
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Questions[] arrayOfQuestions; // array to store all the questions
    private static List<Questions> unansweredQuestions;  // list to store which questions have been answered*/

    private Questions currentQuestion;

    [SerializeField]
    private Text questionText; // question text

    [SerializeField]
    private Text trueAnswerText;

    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private float timeBetweenQuestions = 0.5f; // delay between questions 

    [SerializeField]
    private Animator animation;

    [SerializeField]
    public Text scoreText;

    [SerializeField]
    AudioSource audiosource;

    [SerializeField]
    AudioSource wrong;

    [SerializeField]
    AudioSource right;

    [SerializeField]
    public Text resultsText;


    public static int questionsDone;


    public static int score;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0) // if the list of questions is empty, load this list
        {
            unansweredQuestions = arrayOfQuestions.ToList<Questions>();
        }

        getRandomQuestion(); // loads a random question 
    }

    void getRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count); // index becomes a number between 0 and no of questions
        currentQuestion = unansweredQuestions[randomQuestionIndex]; // current question becomes index value
        scoreText.text = "Correct answers : " + score.ToString() + "/" + questionsDone; 

        questionText.text = currentQuestion.question; // sets question text to current question }
       
        audiosource.clip = currentQuestion.QuestionAudio; // assigns audio clip to current question
        audiosource.Play(); // plays the current question audio

        if (currentQuestion.istrue)
        {
            trueAnswerText.text = "Correct!";
            falseAnswerText.text = "Wrong";
        }
        else
        {
            trueAnswerText.text = "Wrong";
            falseAnswerText.text = "Correct!";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {   unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // restarts the scene to update question

        if (questionsDone == 42)
        {
            SceneManager.LoadScene("resultsScene"); // if questions done = all of them, load results screen
        }

        questionsDone++;

    }

    public void userSelectTrue()
    {
        animation.SetTrigger("True");

        if (currentQuestion.istrue)
        {
            right.Play(); // plays wrong sound
            score++;

        }
        else
        {
            wrong.Play();
        }

        StartCoroutine(TransitionToNextQuestion()); // loads new question after user selection
    }

    public void userSelectFalse()
    {
        animation.SetTrigger("False");

        if (!currentQuestion.istrue)
        {
            right.Play(); // plays wrong sound
            score++;

        }
        else
        {
            wrong.Play();
        }

        StartCoroutine(TransitionToNextQuestion()); // loads new question after user selection
    }

    public void Resetscore() // resets the score and questions answered variables when the user clicks play quiz
    {
        score = 0;
        questionsDone = 0;
    }

}
