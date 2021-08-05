using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed;
    public float upDownSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movePipe();

        InvokeRepeating("switchUpDownMove",0.1f,1f);        //(func,after how much time we should call this func,repeatrate)

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void movePipe()
    {
        rb.velocity = new Vector2(-speed,upDownSpeed);    //move only in x dir
    }

    void switchUpDownMove()
    {
        upDownSpeed = -upDownSpeed; //means when we vcall this func we will change updownspeed to negative
        rb.velocity = new Vector2(speed, upDownSpeed);      //will allow pipes to move up adn down
    }

    //whenever pipe collides with 2d object
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PipeRemover")
        {
            Destroy(gameObject);
        }
    }

}
