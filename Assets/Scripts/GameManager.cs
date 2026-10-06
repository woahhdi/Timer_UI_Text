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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
