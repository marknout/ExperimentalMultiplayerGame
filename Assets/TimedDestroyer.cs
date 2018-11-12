using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroyer : MonoBehaviour {

    public float duration;
    private float timer = 0f;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer > duration)
        {
            Destroy(gameObject);
        }
	}
}
