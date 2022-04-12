using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeLeft : MonoBehaviour
{
    public GameObject gameOver;
    private float Timer = 0f;
    private float TotalTime = 30f;
    public bool isGameActive = true;

    public TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        Timer = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        countdownText.text = "Time: " + Timer.ToString("0");

        if(Timer <= 0)
        {
            Timer = 0;
            gameOver.SetActive(true);
            isGameActive = false;
        }
        else
        {
            isGameActive = true;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
