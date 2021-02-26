using MofaLib.Utilities.EventSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    List<Image> hearts = new List<Image>();
    public SimpleEvent OnPlayerDeathEvent;
    GameObject Player;
    public GameObject Heart;
    int playerLife;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerMovement bird = Player.GetComponent<PlayerMovement>();
        playerLife = bird.Life;

        float heartIconCurrentPose = 0f;
        float heartIconPace = 100f;
        for(int index=0; index < playerLife; ++index)
        {
            GameObject curHeart = Instantiate<GameObject>(Heart,this.transform);
            RectTransform rectangle = curHeart.GetComponent<RectTransform>();

            rectangle.anchoredPosition = new Vector2(heartIconCurrentPose, 0f);
            heartIconCurrentPose += heartIconPace;
            hearts.Add(curHeart.GetComponent<Image>());
        }
    }

    public void OnPlayerHit()
    {
        int heartCounts = hearts.Count;
        if (hearts.Count > 0)
        {
            for(int index = heartCounts - 1; index >=0; --index)
            {
                if(hearts[index].IsActive())
                {
                    hearts[index].enabled = false;
                    if (index == 0)
                    {                      
                        OnPlayerDeathEvent.Raise();
                    }
                    break;
                }
            }          
        }
    }

    public void OnPlayerDeath()
    {
        //Time.timeScale = 0;
    }
}
