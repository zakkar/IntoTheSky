using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : BirdBase
{
    public ScreenLimit SL;
    public float playerSpeed;
    public bool gameOver;
    public float MovingPace = 1.6f;
    public int Life = 3;

    int currentLife;
    Animator playerAnim;

    bool isGamePaused = true;

    void Start()
    {
        tag = "Player";
        currentLife = Life;
        playerAnim = GetComponent<Animator>();
    }


    void Update()
    {
        #region PCControls
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            MoveDown();
        }
        #endregion

        #region MobileControls

        Vector2 touchOrigin = new Vector2();
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.touches[0];
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(myTouch.position);
            touchPosition.z = 0f;
            
            if (touchPosition.x > 0)
            {
                MoveRight();
            }
            else
            {
                MoveLeft();
            }

            if (touchPosition.y > 0)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }
        #endregion

    }

    //Player is gonna move to the right
    private void MoveRight()
    {
        if ((transform.position.x <= SL.limitScreenH))
        {
            transform.Translate(new Vector3(playerSpeed, 0, 0));
        }
    }


    private void MoveLeft()
    {
        if ((transform.position.x >= -SL.limitScreenH))
        {
            transform.Translate(new Vector3(-playerSpeed, 0, 0));
        }
    }

    //player is gonna move up
    private void MoveUp()
    {
        if ((transform.position.y <= SL.limitScreenV))
        {
            transform.Translate(new Vector3(0, playerSpeed, 0));
        }
    }

    //Player is gonna move down
    private void MoveDown()
    {
        if ((transform.position.y >= -SL.limitScreenV))
        {
            transform.Translate(new Vector3(0, -playerSpeed, 0));
        }
    }

    //When Player is gonna hit the enemy 
    public void OnHit()
    {
        currentLife -= 1;
        playerAnim.SetTrigger("PlayerHit");

    }

    //When the player's life = 0 the gameObject will be destroyed 
    public void OnPlayerDeath()
    {
        if (currentLife <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
