using UnityEngine;
using System.Collections;

public class PlayerController2D : MonoBehaviour
{
    public float speeds;
    public ScoreTeam1 score;
    private float xPos;
    public float minX, maxX;

    private void Start()
    {
        xPos = transform.position.x;
    }

    void Update()
    {
        xPos += Input.GetAxis("Horizontal") * speeds * Time.deltaTime;
        xPos = Mathf.Clamp(xPos, minX, maxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        //transform.Translate(Input.GetAxis("Horizontal1") * speeds * Time.deltaTime, 0f, 0f);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        score.scoreValue1 += 10;

        if (col.CompareTag("Barry"))
        {
            score.scoreValue1 += 40;
        }

    }


  

}
