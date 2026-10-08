using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level1_Sky : MonoBehaviour
{
    public TMP_InputField input;
    public Button checkButton;
    public TMP_Text feedback;
    public TMP_Text timerText;
    private float timeRemaining=32f;//2 extra seconds to look at feedback or times up
    private bool isGameActive = true;

    public float timeLimit = 32f;
    bool correct;
    float pause = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // check button lisenter
    
        
        checkButton.onClick.AddListener(() => {// short hand;run function below onclick
            correct= Check_Spelling.checkSpell("sky", input.text.Trim().ToLower());// using checkSpell from Check_Spelling file
            Debug.Log("do words match? "+ correct);
            DisplayFeedback(correct);
            /*for aleeyah- maybe add a 5 second timer here? does not need to be displayed. i think it would just 
            look better to wait a little after feedback instead of immediatly moving to next level*/
            
            //SceneManager.LoadScene(1);// go to level 2
        }); 
    }

    private void Update()
        
    {
        UpdateTimer();
        checkButton.onClick.AddListener(() => {// short hand;run function below onclick
            correct = Check_Spelling.checkSpell("sky", input.text.Trim().ToLower());// using checkSpell from Check_Spelling file
            Debug.Log("do words match? " + correct);
            DisplayFeedback(correct);
            /*for aleeyah- maybe add a 5 second timer here? does not need to be displayed. i think it would just 
            look better to wait a little after feedback instead of immediatly moving to next level*/

            //SceneManager.LoadScene(1);// go to level 2
        });
    }
    public void DisplayFeedback(bool isCorrect)// changes text to show correct or incorrect
    {
    
        if (isCorrect==true)
        {
            feedback.text = "Correct!";

        }
        else
        {
            feedback.text = "Incorrect!";
        }
    }

    

    void UpdateTimer()
    {
   
        if (timeRemaining > 2)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
            timerText.text = "Timer:" + (Mathf.CeilToInt(timeRemaining)-2);
        }else if (timeRemaining<=2 && timeRemaining>1)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log("Time's up!: " + timeRemaining);
            timerText.text = "Time's Up!";

        }else if (timeRemaining <= 1)
        {
            SceneManager.LoadScene(1);
        }


        if (correct==true)
        {
            pause = pause + Time.deltaTime;
            Debug.Log("correct is true, pause: "+ pause);
            if (pause >= 2)// two sceond pause before moving to next level
            {
                SceneManager.LoadScene(1);// go to level 2
            }
        }

    }



}
