using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    private Text myScore;
    private int score = 0;

    private void Start()
    {
        myScore = GameObject.Find("Score").GetComponent<Text>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("∞ÒµÂ ∏‘¿Ω");
            score += 100;
            myScore.text = "Score: " + score.ToString();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 2f;

        if(transform.position.x <= -11)
        {
            Destroy(gameObject);
        }
    }
    

}
