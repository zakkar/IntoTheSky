using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void OnGamePaused()
    {
        StopTime();
    }

    public void OnGameResumed()
    {
        ResumeTime();
    }

    public void OnPlayerDeath()
    {
        StopTime();
    }

    void StopTime()
    {
        Time.timeScale = 0f;
    }

    void ResumeTime()
    {
        Time.timeScale = 1f;
    }
}
