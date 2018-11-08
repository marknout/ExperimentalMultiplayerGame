using UnityEngine;
using System.Collections;

public class Player3Controller2D : MonoBehaviour
{
    public float speeds;


    private void Start()
    {

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal3") * speeds * Time.deltaTime, 0f, 0f);
    }
}
