using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    Quiz.Dificulty dificulty;
    Quiz.Theme theme;

    QuizManager quizManager;

    public Quiz.Dificulty Dificulty { get => dificulty;}
    public Quiz.Theme Theme { get => theme;}

    private void Start()
    {
        quizManager = FindObjectOfType<QuizManager>();
    }

    //Inicia o jogo quando o botãoi iniciar do menu for pressionado
    public void StartGame(int dificultySelected, int themeSelected)
    {
        //Este método vai fechar a janela do menu.
        UIManager.instance.SetMenu(false);

        //Atualizar a dificuldade e tema selecionados. 
        dificulty = (Quiz.Dificulty)dificultySelected;
        theme = (Quiz.Theme)themeSelected;

        //Solicitar um novo quiz.
        quizManager.SelectQuiz(theme, dificulty);
    }

    public void GameOver()
    { 
        //implementação de quando o jogo o acaba.
    }
    
}
