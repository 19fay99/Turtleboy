using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Turtleboy" && SceneManager.GetActiveScene().name == "Level 1")
        {
            SceneManager.LoadScene("Level 2");
        }

        if (collision.name == "Turtleboy" && SceneManager.GetActiveScene().name == "Level 2")
        {
            SceneManager.LoadScene("Level 3");
        }

        if (collision.name == "Turtleboy" && SceneManager.GetActiveScene().name == "Level 3")
        {
            SceneManager.LoadScene("Level 4");
        }

        if (collision.name == "Turtleboy" && SceneManager.GetActiveScene().name == "Level 4")
        {
            SceneManager.LoadScene("Level 5");
        }

        if (collision.name == "Turtleboy" && SceneManager.GetActiveScene().name == "Level 5")
        {
            SceneManager.LoadScene("Complete");
        }

    }
}
