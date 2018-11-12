using UnityEngine;
using System.Collections;

public class randomspawntimershit : MonoBehaviour
{

    private bool Spawn1 = false;
    public GameObject Food;
    private float STimer;


    void Start()
    {
        STimer = Random.Range(1f, 1f);
		StartCoroutine(Timer());
    }

    void Update()
    {
        if (Spawn1 == true)
        {
            Instantiate(Food, transform.position, transform.rotation);
			STimer = Random.Range(1f, 1f);
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