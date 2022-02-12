using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] sfx;
    AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CorrectAnswer()
    {
        AudioSource.PlayOneShot(sfx[0]);
    }

    public void WrongAnswer()
    {
        AudioSource.PlayOneShot(sfx[1]);
    }

    public void GameFinish()
    {
        AudioSource.PlayOneShot(sfx[2]);
    }
}
