using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalPreso : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Niki>() != null)
        {
            //If the bird hits the trigger collider in between the presos then
            //tell the game control that the bird scored.
            
            GameControlGlow.instance.NikiScored(Niki.contador+Niki.contadorReciclaje);
        }
    }
}
