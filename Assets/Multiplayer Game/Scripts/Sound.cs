using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioSource Scored;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            audioSource = GetComponent<AudioSource>();

            audioSource.Play();
        

    }
   
}
