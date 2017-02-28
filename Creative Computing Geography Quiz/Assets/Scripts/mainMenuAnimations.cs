using UnityEngine;
using UnityEngine.UI;

public class mainMenuAnimations : MonoBehaviour {

    [SerializeField]
    public Text resultsText;
    
    private int score;
    private int questionsDone;

    // Use this for initialization

    void Start()
    {
        score = GameManager.score;
        questionsDone = GameManager.questionsDone;
        resultsText.text = "Your score was: " + score.ToString() + "/" + questionsDone;     
    }
}

