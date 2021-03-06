using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer render;
    public float speed = 5.0f;
    public float jumpVelocity;
    public bool onGround = false;
    public int dead = 0;
    private TimeLeft timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = GameObject.Find("Time").GetComponent<TimeLeft>();
        render = GetComponent<SpriteRenderer>();
        if(render == null)
        {
            Debug.Log("Player Sprite is missing a renderer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft.isGameActive == true)
        {
            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += horizontal * Time.deltaTime * speed;

            if(Input.GetAxisRaw("Horizontal") > 0) {
                render.flipX = false;
            }

            if(Input.GetAxisRaw("Horizontal") < 0) {
                render.flipX = true;
            }

            Jump();
            DeathCheck();
        }


    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && onGround == true)
        {
           GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }

    void DeathCheck()
    {
        if(transform.position.y < -10)
        {
            Destroy(this.gameObject);
            dead = 1;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bad")
        {
            Destroy(this.gameObject);
            dead = 1;
        }
    }
}
