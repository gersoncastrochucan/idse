using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residuo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            GameController.instance.BuzoScored();
            Destroy(gameObject, .5f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameController.instance.BuzoScored();
            Destroy(gameObject, .5f);
        }
       

    }
}
