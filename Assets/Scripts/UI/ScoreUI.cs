using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public int ScoreIncrement = 1;
    Text textUI;
    int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        textUI = GetComponent<Text>();
        textUI.text = "Score : " + currentScore.ToString();
    }


    public void OnCollectingCoin()
    {
        currentScore += ScoreIncrement;
        textUI.text = "Score : " + currentScore.ToString();
    }
}
