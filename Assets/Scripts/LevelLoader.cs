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

    public void LoadNextSceen()
    {
        SceneManager.LoadScene(currentSceenIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
