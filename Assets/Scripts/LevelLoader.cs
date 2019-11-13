using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceenIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        currentSceenIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceenIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextSceen();
    }

    public void RestartSceen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceenIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadOptionsSceen()
    {
        SceneManager.LoadScene("Options Screen");
    }

    public void LoadNextSceen()
    {
        SceneManager.LoadScene(currentSceenIndex + 1);
    }

    public void LoadLoseSceen()
    {
        SceneManager.LoadScene("Lose Screen");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
