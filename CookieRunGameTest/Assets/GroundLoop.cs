using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    private float width ;
    private float timer;
    private float delay = 5f;

    private GameObject tileMap;

    private void Awake()
    {
        tileMap = Resources.Load<GameObject>("TilePrefabs/TileMap2");
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            timer -= delay;
            Reposition();

        }

        transform.position += Vector3.left * Time.deltaTime;
        if (transform.position.x <= -12f)
        {
            Destroy(gameObject);
        }
    }

    private void Reposition()
    {
        GameObject tile;

        tile = Instantiate(tileMap, transform.position, Quaternion.identity);    
    }
}