using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewQuiz", menuName = "Quiz")]
public class Quiz : ScriptableObject
{
    [SerializeField, TextArea]
    private string question;
    [SerializeField]
    private string[] answers = new string[4];
    [SerializeField]
    private int correctAnswer;
    [SerializeField]
    private Theme theme;
    [SerializeField]
    private Dificulty dificulty;

    public string Question { get => question; }
    public string[] Answers { get => answers; }
    public Theme GetTheme { get => theme; }
<<<<<<< Updated upstream
    public Dificulty GetDifficulty { get => dificulty; }
    public int CorrectAnswer { get => correctAnswer;}
=======
    public Difficulty GetDificulty { get => dificulty; }
    public int CorrectAnswer { get => correctAnswer; }
>>>>>>> Stashed changes

    public enum Theme { Portuguese, Math, Geography};
    public enum Dificulty { Easy, Medium, Hard};

   // public bool CheckAnswer(int answerSelected)
   // {
<<<<<<< Updated upstream
       // return answerSelected == correctAnswer;
=======
      // return answerSelected == correctAnswer;
>>>>>>> Stashed changes
   // }
}
