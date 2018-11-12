using UnityEngine;
using System.Collections;

public class Fliping2 : MonoBehaviour
{
    public float speeds;
    public ScoreTeam2 score;
    private float xPos;
    public float minX, maxX;
    bool facingRight = true;


    private void Start()
    {
        xPos = transform.position.x;
    }

    void Update ()
    {
        

        if (Input.GetAxis("Horizontal2") < -0.1f) { transform.localScale = new Vector3(-2, 2, 1); }
        if (Input.GetAxis("Horizontal2") > 0.1f) { transform.localScale = new Vector3(2, 2, 1); }

        

    }

}
