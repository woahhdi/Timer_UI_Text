using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level1_Sky : MonoBehaviour
{
    public TMP_InputField input;
    public Button checkButton;
    public TMP_Text feedback;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // check button lisenter
        checkButton.onClick.AddListener(() => {// short hand;run function below onclick
            bool correct= Check_Spelling.checkSpell("sky", input.text.Trim().ToLower());// using checkSpell from Check_Spelling file
            Debug.Log("do words match? "+ correct);
            DisplayFeedback(correct);
            /*for aleeyah- maybe add a 5 second timer here? does not need to be displayed. i think it would just 
            look better to wait a little after feedback instead of immediatly moving to next level*/
            
            //SceneManager.LoadScene(1);// go to level 2
        }); 
    }

    private void Update()
    {

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
    

}
