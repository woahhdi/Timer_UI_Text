using UnityEngine;
using UnityEngine.UI;

public class simpleTimer : MonoBehaviour
{
    public float timer;
    public Text timerText;
    public float timeToRestart;
    
    
    void Update()
    {
        if (timer > timeToRestart)
        {
            timer = 0;
            Debug.Log("Timer has restarted.");
        }
        timer += Time.deltaTime;                        //This means that we are incrementing the timer by the elapsed time since the last frame.
        timerText.text = timer.ToString("F0");          //The F0 in quotations indicates that we are removing the decimal points.
    }
}
