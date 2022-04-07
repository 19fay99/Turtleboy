using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeLeft : MonoBehaviour
{
    float Timer = 0f;
    float TotalTime = 30f;


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
        }
    }
}
