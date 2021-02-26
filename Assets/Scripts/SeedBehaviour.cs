using MofaLib.Utilities.EventSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedBehaviour : MonoBehaviour
{
    public SimpleEvent OnSeedCollected;
    public Animator SeedAnim;

    void Start()
    {
        GetComponent<ScrollElement>().OnSpawn.AddListener(OnReposition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Collided with player");
            OnSeedCollected.Raise();
            SeedAnim.SetTrigger("OnCollected");
            GetComponent<Collider2D>().enabled = false;
        }
    }

    public void OnReposition()
    {
        GetComponent<Collider2D>().enabled = true;
        Debug.Log(gameObject.name + "reposition");
    }
}
