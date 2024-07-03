using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    
    [SerializeField] private Quiz[] quizList;
    [SerializeField] private Quiz currentQuiz;
    private int rightAnswer;

    #region Singleton
        public static QuizManager instance;

    private void Awake()
    {
      instance = this;
    }
    #endregion

    [SerializeField] Quiz.Theme theme;
    [SerializeField] Quiz.Dificulty dificulty;
    int rightAnswers;

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
            rightAnswer++; // ou rightAnswer + 1;
        }
        else
        {
            GameManager.Instance.GameOver();
        }

        UIManager.instance.HighlightButton(currentQuiz.CorrectAnswer, answerSelected);
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

        UIManager.instance.HighlightButton(currentQuiz.CorrectAnswer, answerSelected);
        {

        }
    }   


}
