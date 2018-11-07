using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myTimer : MonoBehaviour {

    public float timerCountdown=60;
    public Text timerText;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timerCountdown -= Time.deltaTime;
        timerText.text = timerCountdown.ToString("f0");
	}
}
