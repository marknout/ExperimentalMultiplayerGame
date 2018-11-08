using UnityEngine;
using System.Collections;

public class Player2Controller2D : MonoBehaviour
{
    public float speeds;


    private void Start()
    {

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal2") * speeds * Time.deltaTime, 0f, 0f);
    }
}
