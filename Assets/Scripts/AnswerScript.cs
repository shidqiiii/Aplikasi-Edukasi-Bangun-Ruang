using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager QuizManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            QuizManager.Correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
            QuizManager.Wrong();
        }
    }
}
