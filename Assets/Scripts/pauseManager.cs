using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager: MonoBehaviour
{
    public static bool pause = false;
    public void modePause()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        TimeCounter.paused = true;
        pause = true;
    }
    public void modePlay()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        TimeCounter.paused = false;
        pause = false;
    }

    private void Start()
    {
        modePlay();
    }
}
