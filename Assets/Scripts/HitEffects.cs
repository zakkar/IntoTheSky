using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffects : MonoBehaviour
{
    bool slowEffect = false;
    public Animator PlayerAnim;
    public float TimeScaleValue;

    // Update is called once per frame
    void Update()
    {
        if (slowEffect)
        {
            Time.timeScale += Time.deltaTime;
            if (Time.timeScale > 0.9f)
            {
                Time.timeScale = 1f;
                slowEffect = false;
                PlayerAnim.SetBool("isHit", false);
            }
        }
    }

    public void OnPlayerHit()
    {
        slowEffect = true;
        Time.timeScale = TimeScaleValue;
        PlayerAnim.SetBool("isHit", true);
    }

    public void OnPlayerDeath()
    {
        this.enabled = false;
    }
}
