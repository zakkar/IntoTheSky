using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            if(child != this)
            {
                transform.gameObject.SetActive(false);
            }
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("GameLevelScene");
        Time.timeScale = 1f;
    }

    public void OnPlayerDeath()
    {
        foreach (Transform child in transform)
        {
            transform.gameObject.SetActive(true);
        }
    }

}
