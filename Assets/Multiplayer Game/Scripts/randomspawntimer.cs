using UnityEngine;
using System.Collections;

public class randomspawntimer : MonoBehaviour
{

    private bool Spawn1 = true;
    public GameObject Food;
    private float STimer;


    void Start()
    {
        STimer = Random.Range(5f, 10f);
    }

    void Update()
    {
        if (Spawn1 == true)
        {
            Instantiate(Food, transform.position, transform.rotation);
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        Spawn1 = false;
        yield return new WaitForSeconds(STimer);
        Spawn1 = true;
    }
}