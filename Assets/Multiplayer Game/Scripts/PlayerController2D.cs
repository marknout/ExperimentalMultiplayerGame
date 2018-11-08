using UnityEngine;
using System.Collections;

public class PlayerController2D : MonoBehaviour
{
    public float speeds;


    private void Start()
    {

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speeds * Time.deltaTime, 0f, 0f);
    }
}
