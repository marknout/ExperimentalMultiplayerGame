using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTeam1 : MonoBehaviour {

    public int scoreValue1 = 0;
    Text score;

    // Use this for initialization
    void Start () {
        score = GetComponent<Text> ();	
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "TEAM 1 : " + scoreValue1.ToString(); 
	}
}
// Add this to points objects "ScoreScript.scorevalue += 10;" //