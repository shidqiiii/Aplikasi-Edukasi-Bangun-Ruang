using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    public void ChangScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
