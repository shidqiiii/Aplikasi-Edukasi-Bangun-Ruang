using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject questionObject;

    public GameObject gamePanel, gameOverPanel;
    public Text scoreText;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Correct()
    {
        score += 10;
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }
    public void Wrong()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    void SetAnswer()
    {
        for (int i= 0;i< options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answer[i];

            if(QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void GenerateQuestion()
    {
        if(QnA.Count > 0)
        {
        currentQuestion = Random.Range(0, QnA.Count);

        questionObject = QnA[currentQuestion].Question;
        SetAnswer();
        }
        else
        {
            Debug.Log("out of question");
            GameOver();
        }
    }

    void GameOver()
    {
        gamePanel.SetActive(false);
        gameOverPanel.SetActive(true);

        scoreText.text = "Nilai " + score;
    }
}
