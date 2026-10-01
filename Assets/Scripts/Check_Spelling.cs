using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Check_Spelling : MonoBehaviour
{
    

   

    public static bool checkSpell(string word, string input)// static- means it dosn't belong to an object. you dont need to make multiple copies of this fuction
    {
        Debug.Log("input: " + input);// making sure we have the word and input
        Debug.Log("word: " + word);
        if (word.Length==input.Length)//checking words are the same length
        {
            for(int i = 0; i < word.Length; i++)//checking each letter is the same
            {
                char wordLetter = word[i];
                char inputLetter = input[i];
                if (wordLetter != inputLetter)
                {
                    Debug.Log("letter mismatch!");
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
   


}




