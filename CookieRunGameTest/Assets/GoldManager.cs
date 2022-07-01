using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    private float randomY;

    private float timer;
    private float delay = 2f;
    private GameObject gold;

    private void Awake()
    {
        gold = Resources.Load<GameObject>("Gold");
        randomY = Random.Range(.3f, .8f);

    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            timer -= delay;
            SpawnGold();
        }
    }
    private void SpawnGold()
    {
        GameObject spawnGold;

        spawnGold = Instantiate(gold, new Vector2(11f, randomY * 2f), Quaternion.identity);
        //transform.localPosition = new Vector3(-.1f * Time.deltaTime, 1, 0) ;
    }
}
