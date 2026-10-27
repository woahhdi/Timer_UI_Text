using UnityEngine;
									//Please do not touch.
[CreateAssetMenu(fileName = "QuizData", menuName = "Word Quiz/Quiz Data")]			//creates a quiz data asset

public class QuizData : ScriptableObject											//makes QuizData into a scriptable object to store quiz information
{
	[System.Serializable]															
	public class Quiz
	{
		public Sprite image;														//allows us to insert a sprite for the word
		public string correctWord;													//allows us to insert the correct word
	}

	public Quiz[] quizzes;															//an array to contain multiple quiz questions, images, words
}