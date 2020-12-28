using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
       // player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {            
                   Destroy(col.gameObject);          
         }
    }
}
