using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    [SerializeField] float levelTime = 10f;
    bool levelFinished = false;


    // Update is called once per frame
    void Update()
    {
        if (levelFinished)
        {
            return;
        }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        if (levelTime < Time.timeSinceLevelLoad)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            levelFinished = true;
        }
    }
}
