using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
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
            // give score to player
        }

        if (collision.gameObject.name.Contains("Enemy Gates"))
        {
            // give score to enemy
        }
    }
}
