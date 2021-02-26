using MofaLib.Utilities.EventSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScrollElement : MonoBehaviour
{
    public float MovingSpeed = 0.01f;
    public bool UseRandomPosition;

    public float RepositionStart = 6f;
    public float RepositionLimit = 6f;

    public float HorizontalLimit = 1.65f;

    //Vector2[] RandomPositions = new Vector2[] { new Vector2(-1.6f, 6f), new Vector2(0f, 6f), new Vector2(1.6f, 6f) };

    public UnityEvent OnSpawn { get; set; } = new UnityEvent();

    private void Start()
    {
        GetRandomPosition();
    }

    Vector2 GetRandomPosition()
    {
        float randX = Random.Range(-HorizontalLimit, HorizontalLimit);
        float randY = Random.Range(RepositionLimit, RepositionStart);
        return new Vector2(randX, randY);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = new Vector2(transform.position.x, transform.position.y - (MovingSpeed * Time.deltaTime));
        transform.position = newPosition;
        if (newPosition.y < -RepositionLimit)
        {
            if (UseRandomPosition)
            {
                transform.position = GetRandomPosition();
            }
            else
            {
                transform.position = new Vector2(transform.position.x, RepositionStart);
            }
            OnSpawn.Invoke();
        }
    }
}
