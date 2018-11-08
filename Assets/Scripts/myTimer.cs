using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myTimer : MonoBehaviour {

    public float timerCountdown=3;
    public Text timerText;
    private bool timerIsActive = true;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if(timerIsActive){
            timerCountdown -= Time.deltaTime;
            timerText.text = timerCountdown.ToString("f0");
            if (timerCountdown <= 0){
                timerCountdown = 0;
                timerIsActive = false;
            }
        }
       
	}
}
