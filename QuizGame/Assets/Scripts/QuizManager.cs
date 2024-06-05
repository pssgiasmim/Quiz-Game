using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
     [SerializeField] private Quiz[] quizList;
     [SerializeField] private Quiz currentQuiz;

     [SerializeField] Quiz.Theme theme;
     [SerializeField] Quiz.Dificulty dificulty;


    public void SelectQuiz(Quiz.Theme themeSelected, Quiz.Dificulty dificultySelected)
    {
        Quiz quiz = quizList[Random.Range(0, quizList.Length)]; 
        if(quiz.GetDificulty == dificultySelected && quiz.GetTheme == themeSelected)
        {
            currentQuiz = quiz;
            UIManager.instance.UpdateQuestion(currentQuiz);
        }
        else
        {
            SelectQuiz(themeSelected, dificultySelected);
        }
    }

    
}
