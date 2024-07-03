using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;

    public void Awake()
    {
        instance = this;
    }
    #endregion

    [SerializeField] Button[] answersButtons;
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] GameObject menuWindow;
    [SerializeField] Button startButton;
<<<<<<< Updated upstream
    [SerializeField]  TMP_Dropdown dificultyDropdown,themeDropdown;
    [SerializeField] Button nextButton;


    private void Start()
    {
        startButton.onClick.AddListener(() => GameManager.Instance.StartGame(dificultyDropdown.value, themeDropdown.value));
        nextButton.onClick.AddListener(() => QuizManager.Instance.SelectQuiz(GameManager.Instance.Theme, GameManager.Instance.Dificulty));

        for (int i = 0; i < answersButtons.Length; i++)
        {
            int x = i;

            answersButtons[i].onClick.AddListener(() => QuizManager.Instance.CheckAnswer(x));
            answersButtons[i].onClick.AddListener(() => nextButton.interactable = true);
        }

=======
    [SerializeField] TMP_Dropdown difficultyDropdown, themeDropdown;
    [SerializeField] Button nextButton;
    private void Start()
    {
        startButton.onClick.AddListener(() => GameManager.Instance.StartGame(difficultyDropdown.value, themeDropdown.value));
        nextButton.onClick.AddListener(()=> QuizManager.instance.SelectQuiz(GameManager.Instance.Theme, Difficulty));

        for (int i = 0; i < answersButtons.Length; i++) ;
        {
            int x = i;

            answersButtons[i].onClick.AddListener(() => QuizManager.instance.CheckAnswer(x));
            answersButtons[i].onClick.AddListener(() => nextButton.interactable = true);

        }
>>>>>>> Stashed changes
    }


    public void UpdateQuestion(Quiz quizSelected)
    {
        questionText.text = quizSelected.Question;

        for(int i = 0; i < answersButtons.Length; i++)
        {
            answersButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = quizSelected.Answers[i];
            answersButtons[i].interactable = true;
<<<<<<< Updated upstream

            answersButtons[i].GetComponent<Image>().color = Color.white;
=======
            answersButtons[i].GetComponent<Image>().color = Color.white;
        }
        nextButton.interactable = false;
    }


    public void HighlightButton(int correctAnswer, int answerSelected)
    {
        correctAnswer.answersButtons.<Image>().color = Color.green;
        if (correctAnswer != correctAnswer)
        {

>>>>>>> Stashed changes
        }

        nextButton.interactable = false;
      
    }

<<<<<<< Updated upstream
    public void HighlightButton(int correctAnswer, int answerSelected)
    {
        answersButtons[correctAnswer].GetComponent<Image>().color = Color.green;
         if (answerSelected != correctAnswer)
         {
            answersButtons[correctAnswer].GetComponent<Image>().color = Color.red;
         }

        for (int i = 0; i < answersButtons.Length; i++)
        {
            answersButtons[i].interactable = true;
        }
    }    
=======
>>>>>>> Stashed changes

    public void SetMenu(bool active)
    {
        menuWindow.SetActive(active);
    }


}
