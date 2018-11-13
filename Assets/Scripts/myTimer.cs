using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class myTimer : MonoBehaviour
{
    //public int scoreValue1;
   //public int scoreValue2;
    public float timerCountdown = 3;
    public float prePause = 6.0f;
    public Text timerText;
    private bool timerIsActive = true;
    public AudioSource audioSourceShit;

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
                    //if (scoreValue1 > scoreValue2)
                   // {
                   //     SceneManager.LoadScene("RedWin");
                  //  }
                  //  else if (scoreValue1 < scoreValue2)
                  //  {
                  //      SceneManager.LoadScene("PurpleWin");
                  //  }
                  //  else
                  //  { // The two scores are equal
                  //      SceneManager.LoadScene("MATHIAS");
                 //   }

                    audioSourceShit.Play();
                    timerCountdown = 0;
                    timerIsActive = false;
                    
                }
            }
        }

    }
}

