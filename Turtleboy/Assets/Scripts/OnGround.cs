using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{

    GameObject Turtleboy;
    // Start is called before the first frame update
    void Start()
    {
        Turtleboy = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Turtleboy.GetComponent<PlayerMovement>().onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            Turtleboy.GetComponent<PlayerMovement>().onGround = false;
        }
    }
}
