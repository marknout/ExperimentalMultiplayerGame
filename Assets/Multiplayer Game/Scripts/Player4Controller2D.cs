using UnityEngine;
using System.Collections;

public class Player4Controller2D : MonoBehaviour
{
    public float speeds;


    private void Start()
    {
        
    }

    void Update ()
    {
        transform.Translate(Input.GetAxis("Horizontal4") * speeds * Time.deltaTime, 0f, 0f);
}
}