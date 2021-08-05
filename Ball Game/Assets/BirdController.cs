using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;

    //we can aalso see this var in unity
    public float upForce;
    bool started;
    bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        started = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started) {

            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.isKinematic = false;
            }

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector2(0, 0);        //reduce velocity so that when user clicks then it is able to move up and down
                rb.AddForce(new Vector2(0, upForce));   //move ball in y dir only
            }

        }
    }

    // when bird crosses/collides with score checker or pillars
    void OnTriggerEnter2D(Collider2D col)
    {
        print(col.gameObject.tag);
        print(GameObject.FindWithTag("Pipe"));
        if (col.gameObject.tag == "Pipe" && !gameOver)
        {
            gameOver = true;
            UIManager.instance.GameOver();
            print("\nover\n");
        }

        if (col.gameObject.tag == "ScoreChecker" && !gameOver)
        {
            ScoreManager.instance.IncrementScore();         //call increment func to increase score
        }

    }

/*    void OnCollisionEnter2D(Collision2D col)
    {
        gameOver = true;
        GameManager.instance.GameOver();

    }*/

}
