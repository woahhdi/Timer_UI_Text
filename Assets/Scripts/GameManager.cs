using UnityEngine;
using UnityEngine.UI;
                                            //Please do not touch. I am copying from the video**
public class GameManager : MonoBehaviour
{
    public QuizData quizData;                   //reference for quizData scriptable object
    public GameObject letterFieldPrefab;        //reference for letter field prefab
    public GameObject letterButtonPrefab;       //reference for letter button prefab

    public Transform letterFieldParent;         //transform for parent letters
    public Transform letterButtonsParent;       //buttons container

    public Text timerText;                      
    public float timeLimit = 30f;

    private Text[] letterFields;                //array of text fields for the letters
    private Button[] letterButtons;             //array for letter buttons

    private int currentFieldIndex = 0;          //tracks which field to fill
    private int currentQuizIndex = 0;           //tracks current quiz

    private float timeRemaining;
    private bool isGameActive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadQuiz(currentQuizIndex);             //calling the LoadQuiz
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameActive)                        //checking if th game is active                
        {
            UpdateTimer();                      //if it is, update the timer
        }
    }

    void LoadQuiz(int quizIndex)
    {
        Debug.Log("Loading Quiz: " + quizIndex);

        if(quizDate == null || quizData.quizzes == null || quizData.quizzes.Length == 0)        //checking if quiz data and the quiz array are valid
        {
            Debug.LogError("Quiz Data or quizzes is not set up correctly!");
            return;
        }

        if(quizIndex < 0 || quizIndex >= quizData.quizzes.Length)
        {
            Debug.LogError("Invalid quiz index: " + quizIndex);
            return;
        }

        QuizData.Quiz quiz = quizData.quizzes[quizIndex];

        Image image = GameObject.Find("QuizImage")?.GetComponent<Image>();
        if(image == null)
        {
            Debug.LogError("Quiz Image not found or missing.");
            return;
        }


    }

    void UpdateTimer()
    {

    }
}
