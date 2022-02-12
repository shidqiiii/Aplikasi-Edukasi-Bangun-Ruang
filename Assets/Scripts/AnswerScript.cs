using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager QuizManager;
    
    public AudioManager AudioManager;

    public Color startColor;

    // Start is called before the first frame update
    void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Answer()
    {
        if (isCorrect)
        {
            AudioManager.CorrectAnswer();
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct Answer");
            QuizManager.Correct();
        }
        else
        {
            AudioManager.WrongAnswer();
            GetComponent<Image>().color = Color.red;
            Debug.Log("Wrong Answer");
            QuizManager.Wrong();
        }
    }
}
