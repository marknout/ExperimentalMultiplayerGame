using UnityEngine;
using System.Collections;

public class Player4Controller2D : MonoBehaviour
{
    public float speeds;
    public ScoreTeam2 score;
    private float xPos;
    public float minX, maxX;

    private void Start()
    {
        xPos = transform.position.x;
    }

    void Update ()
    {
        xPos += Input.GetAxis("Horizontal4") * speeds * Time.deltaTime;
        xPos = Mathf.Clamp(xPos, minX, maxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        //transform.Translate(Input.GetAxis("Horizontal4") * speeds * Time.deltaTime, 0f, 0f);
}


    void OnTriggerEnter2D(Collider2D col)
    {
        score.scoreValue2 += 10;

        if (col.CompareTag("Barry"))
        {
            score.scoreValue2 += 40;
        }

    }


}