using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    public AudioSource audioSourceShit;
    public AudioSource audioSourceFood;
    public AudioSource audioSourceBarry;
    public AudioSource audioSourcePickUp;
    public AudioSource audioSourcePickUpFood;
    public AudioSource audioSourcePickUpBarry;
    public AudioSource audioSourcePickUpShit;
    public AudioSource audioSourcePickUpGold;
    public AudioSource audioSourceGoldenFood;

    private void OnTriggerEnter2D(Collider2D col)
    {

        

        
            if (col.CompareTag("Shit"))
            {
            audioSourceShit.Play();
            audioSourcePickUpShit.Play();

        }


        
            if (col.CompareTag("Food"))
                {
            audioSourceFood.Play();
            audioSourcePickUpFood.Play();
            

        }


        {
            if (col.CompareTag("Barry"))
                 {
            audioSourceBarry.Play();
            audioSourcePickUp.Play();
            audioSourcePickUpBarry.Play();
            }

            if (col.CompareTag("Gold"))
            {
                
                audioSourcePickUp.Play();
                audioSourcePickUpGold.Play();
                audioSourceGoldenFood.Play();
            }




        }
   
}
}
