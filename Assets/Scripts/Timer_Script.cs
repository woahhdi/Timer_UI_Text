using UnityEngine;
using UnityEngine.UI;

public class Timer_Script : MonoBehaviour
{
    public Text timerText;
    public float timeLimit = 30f;

    private float timeRemaining;
    private bool isGameActive = true;
   
    void UpdateTimer()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "" + Mathf.CeilToInt(timeRemaining).ToString();
        }

        else
        {
            Debug.Log ("Time's up!");
            isGameActive = false;
            //CheckReply();                                   //Needs to be implemented with CheckReply Script. I can add later.
        }

    }

    
}
