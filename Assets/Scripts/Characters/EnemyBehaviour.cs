using MofaLib.Utilities.EventSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : BirdBase
{
    public SimpleEvent PlayerCollisionEvent;

    void Start()
    {
        GetComponent<ScrollElement>().OnSpawn.AddListener(OnReposition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Collided with player");
            PlayerCollisionEvent.Raise();
        }
    }

    public void OnReposition()
    {
       Debug.Log(gameObject.name + "reposition");
    }
}
