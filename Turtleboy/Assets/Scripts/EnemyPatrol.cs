using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 100;
    public bool patrol;
    public bool turn;
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private TimeLeft timeLeft;
    void Start()
    {
        timeLeft = GameObject.Find("Time").GetComponent<TimeLeft>();
        patrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(patrol == true && timeLeft.isGameActive == true)
        {
            Patrol();
        }
    }

    private void FixedUpdate()
    {
        if(patrol == true)
        {
            turn = !Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        }
    }

    void Patrol()
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
        if (turn == true)
        {

            Turn();


        }
    }

    void Turn()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        turn = false;
    }
}
