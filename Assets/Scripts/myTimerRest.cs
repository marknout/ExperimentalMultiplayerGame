using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class myTimerRest : MonoBehaviour
{

    public float timerCountdown = 3;
    public float prePause = 6.0f;
    public Text timerText;
    private bool timerIsActive = true;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
        timerText.text = timerCountdown.ToString("f0");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsActive)
        {
            if (prePause > 0)
            {
                prePause -= Time.deltaTime;
                if (prePause <= 0)
                {
                    GameObject go = GameObject.Find("Countdown");
                    if (go != null)
                    {
                        Destroy(go);
                    }
                }
            }
            else
            {
                timerCountdown -= Time.deltaTime;
                timerText.text = timerCountdown.ToString("f0");
                if (timerCountdown <= 0)
                   
                {
                    SceneManager.LoadScene("MainMenu");
                    timerCountdown = 0;
                    timerIsActive = false;
                    
                }
            }
        }

    }
}

