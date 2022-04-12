using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public bool onGround = false;
    public int dead = 0;
    private TimeLeft timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = GameObject.Find("Time").GetComponent<TimeLeft>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft.isGameActive == true)
        {
            Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += horizontal * Time.deltaTime * speed;

            Jump();
            DeathCheck();
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && onGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
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
}
