using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    
    [SerializeField] private Quiz[] quizList;
    [SerializeField] private Quiz currentQuiz;

    [SerializeField] Quiz.Theme theme;
    [SerializeField] Quiz.Dificulty dificulty;
    

    #region Singleton
    public static QuizManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public void SelectQuiz(Quiz.Theme themeSelected, Quiz.Dificulty dificultySelected)
    {
        Quiz quiz = quizList[Random.Range(0, quizList.Length)];
        if (quiz.GetDifficulty == dificultySelected && quiz.GetTheme == themeSelected)
        {
            currentQuiz = quiz;
            UIManager.instance.UpdateQuestion(currentQuiz);
        }
        else
        {
            SelectQuiz(themeSelected, dificultySelected);
        }
    }

    public void CheckAnswer(int answerSelected)
    {
        if (answerSelected == currentQuiz.CorrectAnswer)
        {
            rightAnswers++;
        }
        else
        {
            GameManager.Instance.GameOver();
        }

        UIManager.instance.HighLightButton(currentQuiz.CorrectAnswer, answerSelected);
        {

        }
    }   


}
