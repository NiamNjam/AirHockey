using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ball : MonoBehaviour
{
    int PlayerScore = 0;
    int EnemyScore = 0;

    public TMP_Text playerScore;
    public TMP_Text enemyScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.name.Contains("Gates"))
        {
            print("Goal!!!");
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        


        if (collision.gameObject.name.Contains("Player Gates"))
        {
            //int score = 0;
            PlayerScore += 1;
            playerScore.text = PlayerScore.ToString();

            
        }

        if (collision.gameObject.name.Contains("Enemy Gates"))
        {
            // give score to enemy
            EnemyScore += 1;
            enemyScore.text = EnemyScore.ToString();

        }
    }
}
