﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && col.isTrigger)
        {
          
            Destroy(gameObject);
        }
        
    }



}
