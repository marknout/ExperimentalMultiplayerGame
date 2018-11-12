using UnityEngine;
using System.Collections;

public class Player4Controller2D : MonoBehaviour
{
    public float speeds;
    public ScoreTeam2 score;
    private float xPos;
    public float minX, maxX;
    public GameObject Points50;
    public GameObject Points10;
    public GameObject Points100;
    public GameObject Sparkes;
    public Transform visual;




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
        if (col.CompareTag("Shit"))
        {
            speeds = speeds - 1;
            score.scoreValue2 -= 20;
        }


        if (col.CompareTag("Gold"))
        {
            speeds = speeds + 1;
            score.scoreValue2 = score.scoreValue2 + 100;
            Instantiate(Points100, transform);
            Instantiate(Sparkes, visual.transform);
            //Points100.SetActive(true);
            //Sparkes.SetActive(true);
        }
        else
        {
            //Points100.SetActive(false);
            //Sparkes.SetActive(false);
        }


        if (col.CompareTag("Barry"))
        {
            score.scoreValue2 += 50;
            Instantiate(Points50, transform);
            Instantiate(Sparkes, visual.transform);
            //Points50.SetActive(true);
            //Sparkes.SetActive(true);
        }
        else
        {
            //Points50.SetActive(false);
            //Sparkes.SetActive(false);
        }


        if (col.CompareTag("Food"))
        {
            score.scoreValue2 += 10;
            Instantiate(Points10, transform);
            Instantiate(Sparkes, visual.transform);
            //Points10.SetActive(true);
            //Sparkes.SetActive(true);
        }
        else
        {
            //Points10.SetActive(false);
            //Sparkes.SetActive(false);
        }


    }




}




