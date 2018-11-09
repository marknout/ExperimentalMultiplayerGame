using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTeam2 : MonoBehaviour {

    public int scoreValue2 = 0;
    Text score;

    // Use this for initialization
    void Start () {
        score = GetComponent<Text> ();	
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "TEAM 2 : " + scoreValue2.ToString(); 
	}
}
// Add this to points objects "ScoreScript.scorevalue += 10;" //