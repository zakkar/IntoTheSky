using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTilesManager : MonoBehaviour
{
    public List<GameObject> Tiles = new List<GameObject>();
    public float MovingSpeed = 10;
    public float RepositionLimit = 8;

    // Update is called once per frame
    void Update()
    {
        for (int index = 0; index < Tiles.Count; ++index)
        {
            Vector3 position = Tiles[index].transform.position;
            Vector2 newPosition = new Vector2(position.x, position.y - (MovingSpeed * Time.deltaTime));
            if (newPosition.y < -RepositionLimit)
            {
                int nextTileIndex = index + 1 % Tiles.Count;
                nextTileIndex = nextTileIndex == Tiles.Count ? 0 : nextTileIndex;
                Debug.Log("Next index :" + nextTileIndex + "Current Index : " + index);
                Vector3 nextPosition = Tiles[nextTileIndex].transform.position;
                Vector3 scale = Tiles[nextTileIndex].transform.localScale;
                Tiles[index].transform.position = new Vector2(nextPosition.x, nextPosition.y + scale.y * 9f); //scale.y * 9f We mutiply by object size the pivot is at the center of the object
            }
            else
            {
                Tiles[index].transform.position = newPosition;
            }
        }
    }
}
